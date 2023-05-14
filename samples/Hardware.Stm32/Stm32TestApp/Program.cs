using System;
using System.Diagnostics;
using System.Threading;
using nanoFramework;
using nanoFramework.Runtime;
using nanoFramework.Runtime.Events;
using STM32 = nanoFramework.Hardware.Stm32;
using GPIO = System.Device.Gpio;

namespace Stm32TestApp
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            var _gpio = new GPIO.GpioController();
            var _pin12 = _gpio.OpenPin(12);

            Thread.Sleep(Timeout.Infinite);

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }
    }
}
