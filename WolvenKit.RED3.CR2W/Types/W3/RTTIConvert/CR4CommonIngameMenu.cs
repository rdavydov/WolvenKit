using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4CommonIngameMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_menuData", 2,0)] 		public CArray<SMenuTab> M_menuData { get; set;}

		[Ordinal(2)] [RED("currentMenuName")] 		public CName CurrentMenuName { get; set;}

		[Ordinal(3)] [RED("reopenRequested")] 		public CBool ReopenRequested { get; set;}

		public CR4CommonIngameMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4CommonIngameMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}