using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskActivateOnlyOnceDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("successOnly")] 		public CBool SuccessOnly { get; set;}

		[Ordinal(2)] [RED("resetWhenReattachFromPool")] 		public CBool ResetWhenReattachFromPool { get; set;}

		[Ordinal(3)] [RED("resetOnGameplayEvent")] 		public CName ResetOnGameplayEvent { get; set;}

		public CBTTaskActivateOnlyOnceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskActivateOnlyOnceDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}