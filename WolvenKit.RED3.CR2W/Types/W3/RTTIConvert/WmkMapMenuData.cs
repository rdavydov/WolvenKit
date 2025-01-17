using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class WmkMapMenuData : CObject
	{
		[Ordinal(1)] [RED("merchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> MerchantPins { get; set;}

		[Ordinal(2)] [RED("removedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> RemovedMerchantPins { get; set;}

		[Ordinal(3)] [RED("replacedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> ReplacedMerchantPins { get; set;}

		[Ordinal(4)] [RED("deletedMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> DeletedMerchantPins { get; set;}

		[Ordinal(5)] [RED("removedSameUniqueTagMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> RemovedSameUniqueTagMerchantPins { get; set;}

		[Ordinal(6)] [RED("replacedSameTypePosMerchantPins", 2,0)] 		public CArray<WmkMerchantMapPin> ReplacedSameTypePosMerchantPins { get; set;}

		public WmkMapMenuData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new WmkMapMenuData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}