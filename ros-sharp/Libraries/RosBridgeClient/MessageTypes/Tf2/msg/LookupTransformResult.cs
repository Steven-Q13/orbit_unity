/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Tf2
{
    public class LookupTransformResult : Message
    {
        public const string RosMessageName = "tf2_msgs/LookupTransformResult";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public TransformStamped transform { get; set; }
        public TF2Error error { get; set; }

        public LookupTransformResult()
        {
            this.transform = new TransformStamped();
            this.error = new TF2Error();
        }

        public LookupTransformResult(TransformStamped transform, TF2Error error)
        {
            this.transform = transform;
            this.error = error;
        }
    }
}