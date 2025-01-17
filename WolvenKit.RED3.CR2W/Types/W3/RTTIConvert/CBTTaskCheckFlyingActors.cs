using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckFlyingActors : IBehTreeTask
	{
		[Ordinal(1)] [RED("minFlyingActors")] 		public CInt32 MinFlyingActors { get; set;}

		[Ordinal(2)] [RED("maxFlyingActors")] 		public CInt32 MaxFlyingActors { get; set;}

		[Ordinal(3)] [RED("flyingCheckType")] 		public CEnum<EFlyingCheck> FlyingCheckType { get; set;}

		[Ordinal(4)] [RED("nextActionTime")] 		public CFloat NextActionTime { get; set;}

		[Ordinal(5)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(6)] [RED("ifNot")] 		public CBool IfNot { get; set;}

		public CBTTaskCheckFlyingActors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckFlyingActors(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}