using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IsVehicleDoorLocked : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("isCheckInverted")] public CBool IsCheckInverted { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }

		public IsVehicleDoorLocked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}