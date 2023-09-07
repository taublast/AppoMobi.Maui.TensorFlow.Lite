# AppoMobi.Maui.TensorFlow.Lite

### .NET Android bindings for Google's TensorFlow Lite with GPU support

##### Includes:

* TensorFlow.Lite (v2.13.0)
* TensorFlow.Lite.Api (v2.13.0)
* TensorFlow.Lite.Gpu (v2.13.0)
* TensorFlow.Lite.Gpu.Api (v2.13.0)

## Nuget package

`AppoMobi.Maui.TensorFlow.Lite`

## How to use

To implement gpu acceleration as described here:

https://www.tensorflow.org/lite/android/delegates/gpu?hl=en#enable_gpu_acceleration_2

```csharp

using AppoMobi.Maui.TensorFlow.Lite;
using AppoMobi.Maui.TensorFlow.Lite.GPU;

...

var options = new Interpreter.Options();

var compatList = new CompatibilityList();
if (compatList.IsDelegateSupportedOnThisDevice && useGpu)
{
    var bestOptions = compatList.BestOptionsForThisDevice;
    var gpuDelegate = new GpuDelegate(bestOptions);
    options.AddDelegate(gpuDelegate);
}
```

You do not need `tensorflow-lite-gpu-delegate-plugin` for this.


#### Why another bindings package?

Initially it was impossible to use `BestOptionsForThisDevice` with `Xamarin.TensorFlow.Lite.*` nugets.
https://github.com/xamarin/GooglePlayServicesComponents/issues/793 