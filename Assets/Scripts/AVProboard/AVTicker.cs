using System;
using RenderHeads.Media.AVProVideo;
using UnityEngine;

namespace QTC
{
    public class AVTicker : MonoBehaviour
    {
        private MediaPlayer mediaPlayer;
        public Action<double> onTimeInMilliSecondUpdate;

        public void Init(MediaPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
        }

        private void Update()
        {
            if (onTimeInMilliSecondUpdate != null && mediaPlayer != null)
            {
                onTimeInMilliSecondUpdate.Invoke(mediaPlayer.Control.GetCurrentTime());
            }
        }
    }
}