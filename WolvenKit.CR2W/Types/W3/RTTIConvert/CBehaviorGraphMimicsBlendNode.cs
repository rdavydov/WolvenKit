using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicsBlendNode : CBehaviorGraphNode
	{
		[RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphNode> CachedFirstInputNode { get; set;}

		[RED("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphNode> CachedSecondInputNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("type")] 		public CEnum<EBehaviorMimicBlendType> Type { get; set;}

		public CBehaviorGraphMimicsBlendNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicsBlendNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}