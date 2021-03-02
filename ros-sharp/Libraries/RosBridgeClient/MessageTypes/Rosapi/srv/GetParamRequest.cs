/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class GetParamRequest : Message
    {
        public const string RosMessageName = "rosapi/GetParam";

        public string name { get; set; }

        public string @default { get; set; }

        public GetParamRequest()
        {
            this.name = "";
            this.@default = "";
        }

        public GetParamRequest(string name, string _default)
        {
            this.name = name;
            this.@default = _default;
        }
    }
}
