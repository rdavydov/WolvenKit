using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EnchantingMenu : CR4MenuBase
	{
		[RED("m_fxEnableRemovingEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxEnableRemovingEnchantment { get; set;}

		[RED("m_fxEnableEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxEnableEnchantment { get; set;}

		[RED("m_fxSetFilters")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

		[RED("m_fxSetLocalization")] 		public CHandle<CScriptedFlashFunction> M_fxSetLocalization { get; set;}

		[RED("m_fxStartApplying")] 		public CHandle<CScriptedFlashFunction> M_fxStartApplying { get; set;}

		[RED("m_fxStartRemoving")] 		public CHandle<CScriptedFlashFunction> M_fxStartRemoving { get; set;}

		[RED("m_fxSelectFirstEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxSelectFirstEnchantment { get; set;}

		[RED("m_fxSetPinnedRecipe")] 		public CHandle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

		[RED("m_definitionsManager")] 		public CHandle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

		[RED("m_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> M_tooltipDataProvider { get; set;}

		[RED("m_playerInvComponent")] 		public CHandle<W3GuiEnchantingInventoryComponent> M_playerInvComponent { get; set;}

		[RED("m_playerInventory")] 		public CHandle<CInventoryComponent> M_playerInventory { get; set;}

		[RED("m_enchanterInventory")] 		public CHandle<CInventoryComponent> M_enchanterInventory { get; set;}

		[RED("m_enchanterNpc")] 		public CHandle<CNewNPC> M_enchanterNpc { get; set;}

		[RED("m_craftsmanComponent")] 		public CHandle<W3CraftsmanComponent> M_craftsmanComponent { get; set;}

		[RED("m_enchantmentManager")] 		public CHandle<W3EnchantmentManager> M_enchantmentManager { get; set;}

		[RED("m_runewordsList", 2,0)] 		public CArray<CName> M_runewordsList { get; set;}

		[RED("m_glyphwordsList", 2,0)] 		public CArray<CName> M_glyphwordsList { get; set;}

		[RED("m_allWordsList", 2,0)] 		public CArray<CName> M_allWordsList { get; set;}

		[RED("m_runewordsData")] 		public CHandle<CScriptedFlashArray> M_runewordsData { get; set;}

		[RED("m_glyphwordsData")] 		public CHandle<CScriptedFlashArray> M_glyphwordsData { get; set;}

		[RED("m_allwordsData")] 		public CHandle<CScriptedFlashArray> M_allwordsData { get; set;}

		[RED("m_initDataConfirmation")] 		public CHandle<EnchantingConfirmationPopupData> M_initDataConfirmation { get; set;}

		[RED("m_selectedEnchantment")] 		public CName M_selectedEnchantment { get; set;}

		[RED("m_readonly")] 		public CBool M_readonly { get; set;}

		[RED("m_notEnoughSlots")] 		public CBool M_notEnoughSlots { get; set;}

		[RED("m_prevItem")] 		public SItemUniqueId M_prevItem { get; set;}

		[RED("TYPE_RUNEWORD")] 		public CInt32 TYPE_RUNEWORD { get; set;}

		[RED("TYPE_GLYPHWORD")] 		public CInt32 TYPE_GLYPHWORD { get; set;}

		[RED("tutorialTriggered")] 		public CBool TutorialTriggered { get; set;}

		public CR4EnchantingMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4EnchantingMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}