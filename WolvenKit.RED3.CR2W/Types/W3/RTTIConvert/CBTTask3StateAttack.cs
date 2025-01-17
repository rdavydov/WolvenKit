using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateAttack : CBTTaskAttack
	{
		[Ordinal(1)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(2)] [RED("endTaskWhenOwnerGoesPastTarget")] 		public CBool EndTaskWhenOwnerGoesPastTarget { get; set;}

		[Ordinal(3)] [RED("endLoopOnDistance")] 		public CBool EndLoopOnDistance { get; set;}

		[Ordinal(4)] [RED("distanceToTarget")] 		public CFloat DistanceToTarget { get; set;}

		[Ordinal(5)] [RED("stopRotatingWhenTargetIsBehind")] 		public CBool StopRotatingWhenTargetIsBehind { get; set;}

		[Ordinal(6)] [RED("playFXOnLoopStart")] 		public CName PlayFXOnLoopStart { get; set;}

		[Ordinal(7)] [RED("playLoopFXInterval")] 		public CFloat PlayLoopFXInterval { get; set;}

		[Ordinal(8)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(9)] [RED("startDeactivationEventName")] 		public CName StartDeactivationEventName { get; set;}

		[Ordinal(10)] [RED("endDeactivationEventName")] 		public CName EndDeactivationEventName { get; set;}

		[Ordinal(11)] [RED("startPos")] 		public Vector StartPos { get; set;}

		[Ordinal(12)] [RED("lastFXTime")] 		public CFloat LastFXTime { get; set;}

		public CBTTask3StateAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}