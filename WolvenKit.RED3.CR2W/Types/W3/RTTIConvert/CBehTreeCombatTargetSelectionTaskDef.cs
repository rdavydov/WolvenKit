using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeCombatTargetSelectionTaskDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("maxTargetDistance")] 		public CFloat MaxTargetDistance { get; set;}

		[Ordinal(2)] [RED("playerPriority")] 		public CInt32 PlayerPriority { get; set;}

		[Ordinal(3)] [RED("targetOnlyPlayer")] 		public CBool TargetOnlyPlayer { get; set;}

		public CBehTreeCombatTargetSelectionTaskDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeCombatTargetSelectionTaskDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}