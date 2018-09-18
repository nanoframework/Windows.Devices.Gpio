//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Devices.Gpio
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGpioController
    {
        /// <summary>
        /// 
        /// </summary>
        int PinCount
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pinNumber"></param>
        /// <returns></returns>
        IGpioPin OpenPin(int pinNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pinNumber"></param>
        /// <param name="sharingMode"></param>
        /// <returns></returns>
        IGpioPin OpenPin(int pinNumber, GpioSharingMode sharingMode);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pinNumber"></param>
        /// <param name="sharingMode"></param>
        /// <param name="pin"></param>
        /// <param name="openStatus"></param>
        /// <returns></returns>
        bool TryOpenPin(int pinNumber, GpioSharingMode sharingMode, out IGpioPin pin, out GpioOpenStatus openStatus);
    }
}
