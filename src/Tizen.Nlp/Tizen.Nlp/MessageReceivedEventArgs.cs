/*
* Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using Tizen.Applications;

namespace Tizen.Nlp
{
    /// <summary>
    /// This custom class extend from EventArgs to obtain Bundle object.
    /// </summary>
    /// <since_tizen> 5 </since_tizen>
    public class MessageReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// An Bundle type to carry an array struct return from tidl service.
        /// To check which nlp command be return by  msg.GetItem("command")
        /// To get value by  msg.GetItem("return_tag") and cast the value to string []
        /// To get value by  msg.GetItem("return_token") and cast the value to string []
        /// </summary>
        public Bundle Message { get; set; }
    }
}