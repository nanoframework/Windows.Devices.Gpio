//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using nanoFramework.Runtime.Events;

namespace System.Device.Gpio
{
    internal class GpioPinEvent : BaseEvent
    {
        public int PinNumber;
        public GpioPinEdge Edge;
    }
}
