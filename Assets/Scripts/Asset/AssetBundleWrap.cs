using System.Collections.Generic;
using UnityEngine;

namespace QTC
{
    public class AssetBundleWrap
    {
        public AssetBundle assetBundle;
        public List<AssetBundleWrap> abDeps;
        public List<AssetBundleWrap> abRefs;
        public List<Object> objRefs;
        public bool isAlive;

        public int referenceCount
        {
            get
            {
                abRefs.RemoveAll(item => !item.isAlive);
                objRefs.RemoveAll(item => item == null);

                return abRefs.Count + objRefs.Count;
            }
        }

        public AssetBundleWrap(AssetBundle assetBundle)
        {
            this.assetBundle = assetBundle;
            abDeps = new List<AssetBundleWrap>();
            abRefs = new List<AssetBundleWrap>();
            objRefs = new List<Object>();
        }
    }
}