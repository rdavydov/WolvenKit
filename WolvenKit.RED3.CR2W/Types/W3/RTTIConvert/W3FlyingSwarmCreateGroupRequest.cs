using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FlyingSwarmCreateGroupRequest : CObject
	{
		[Ordinal(1)] [RED("boidCount")] 		public CInt32 BoidCount { get; set;}

		[Ordinal(2)] [RED("spawnPOI")] 		public CName SpawnPOI { get; set;}

		public W3FlyingSwarmCreateGroupRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FlyingSwarmCreateGroupRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}