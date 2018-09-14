//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Devices.Gpio
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGpioPin
    {
        /// <summary>
        /// 
        /// </summary>
        TimeSpan DebounceTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        int PinNumber
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        GpioSharingMode SharingMode
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        event GpioPinValueChangedEventHandler ValueChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driveMode"></param>
        /// <returns></returns>
        bool IsDriveModeSupported(GpioPinDriveMode driveMode);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        GpioPinDriveMode GetDriveMode();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void SetDriveMode(GpioPinDriveMode value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void Write(GpioPinValue value);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        GpioPinValue Read();
    }
}
