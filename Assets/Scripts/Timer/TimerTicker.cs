using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QTC.Timer
{
	/// 为Timer提供一个Unity运行时生命周期的环境
	public class TimerTicker : SingletonBehaviour<TimerTicker>
	{
		private List<Timer> registeredTimer = new List<Timer>();	// 注册中的定时器
		private List<Timer> timerToRegister = new List<Timer>();	// 防止遍历当中修改
		private List<Timer> timerToRemove = new List<Timer>();		// 因为异常情况要被移除的Timer
		
		private void Update()
		{
			registeredTimer.AddRange(timerToRegister);
			timerToRegister.Clear();
			
			foreach (var timer in registeredTimer)
			{
				if (!timer.isDone)
				{
					try
					{
						timer.Update();
					}
					catch (Exception)
					{
						timerToRemove.Add(timer); // 引发异常的Timer直接会被抛弃
					}
				}
			}

			registeredTimer.RemoveAll(timer => timer.isDone);
			foreach (var timer in timerToRemove)
			{
				registeredTimer.Remove(timer);
			}
			timerToRemove.Clear();
		}

		public void RegisterTimer(Timer timer)
		{
			// 如果时间 <= 0，Timer的回调会转成同步，当帧处理
			if (timer.duration <= 0)
			{
				timer.Update();
				return;
			}
			
			timerToRegister.Add(timer);
		}
	}
}


