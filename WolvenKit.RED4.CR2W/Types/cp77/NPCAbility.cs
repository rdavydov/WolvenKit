using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCAbility : CVariable
	{
		private CString _abilityName;

		[Ordinal(0)] 
		[RED("abilityName")] 
		public CString AbilityName
		{
			get => GetProperty(ref _abilityName);
			set => SetProperty(ref _abilityName, value);
		}

		public NPCAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}