using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GlossaryStorybookMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("allEntries", 2,0)] 		public CArray<CHandle<CJournalStoryBookChapter>> AllEntries { get; set;}

		[Ordinal(2)] [RED("guiManager")] 		public CHandle<CR4GuiManager> GuiManager { get; set;}

		[Ordinal(3)] [RED("bMovieIsPlaying")] 		public CBool BMovieIsPlaying { get; set;}

		[Ordinal(4)] [RED("m_fxSetTitle")] 		public CHandle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

		[Ordinal(5)] [RED("m_fxSetText")] 		public CHandle<CScriptedFlashFunction> M_fxSetText { get; set;}

		[Ordinal(6)] [RED("m_fxShowModules")] 		public CHandle<CScriptedFlashFunction> M_fxShowModules { get; set;}

		public CR4GlossaryStorybookMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GlossaryStorybookMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}