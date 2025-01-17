using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondCleanShot : IBehTreeTask
	{
		[Ordinal(1)] [RED("doStaticTraceOnNavTestFailure")] 		public CBool DoStaticTraceOnNavTestFailure { get; set;}

		[Ordinal(2)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(3)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(4)] [RED("target")] 		public CHandle<CNode> Target { get; set;}

		[Ordinal(5)] [RED("ownerPos")] 		public Vector OwnerPos { get; set;}

		[Ordinal(6)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(7)] [RED("res")] 		public CBool Res { get; set;}

		public CBTCondCleanShot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondCleanShot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}