using AppoMobi.Maui.TensorFlow.Lite;
using AppoMobi.Maui.TensorFlow.Lite.GPU;

namespace Test;

// All the code in this file is included in all platforms.
public class Lib
{
    static void CheckBindings()
    {
        bool useGpu = true;

        var options = new Interpreter.Options();

        var compatList = new CompatibilityList();
        if (compatList.IsDelegateSupportedOnThisDevice && useGpu)
        {
            var bestOptions = compatList.BestOptionsForThisDevice;
            var gpuDelegate = new GpuDelegate(bestOptions);
            options.AddDelegate(gpuDelegate);
        }
    }
}