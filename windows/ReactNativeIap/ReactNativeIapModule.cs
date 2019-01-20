using ReactNative.Bridge;
using ReactNative.Bridge.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactNativeIap
{
    public class RNIapModule : ReactContextNativeModuleBase, ILifecycleEventListener
    {

        public RNIapModule(ReactContext reactContext)
            : base(reactContext)
        {

        }

        public override string Name => "ReactIap";

        public override IReadOnlyDictionary<string, object> Constants => new Dictionary<string, object>()
        {
            { "test", "test" }
        };

        public void OnSuspend()
        {
        }

        public void OnResume()
        {
        }

        public void OnDestroy()
        {
        }


        [ReactMethod]
        public void test(ICallback callback)
        {
        }
    }
}
