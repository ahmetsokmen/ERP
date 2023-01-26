using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Entities
{
	public class Enums
	{
		public enum EmployeeStatus
		{
			[Display(Name="Aktif")]
			Active,

			[Display(Name = "İşten Ayrıldı")]
			LeftJob

		}

		public enum Gender
		{
			[Display(Name = "Bilinmiyor")]
			Unknown,

			[Display(Name = "Kadın")]
			Active,

			[Display(Name = "Erkek")]
			LeftJob

		}

		public enum CRMTaskStatus
		{
			[Display(Name = "Oluşturuldu")]
			Created,

			[Display(Name = "Personel Atandı")]
			Assigned,

			[Display(Name = "Çalışma Başlatıldı")]
			InProgress,

			[Display(Name = "İptal Edildi")]
			Canceled,

			[Display(Name = "Onay Sürecinde")]
			Evaluating,

			[Display(Name = "İptal Edildi")]
			Done,

		}

		public enum Priority
		{
			[Display(Name = "Çok Düşük")]
			TooLow,

			[Display(Name = "Düşük")]
			Low,

			[Display(Name = "Orta")]
			Middle,

			[Display(Name = "Yüksek")]
			High,

			[Display(Name = "Çok Yüksek")]
			TooHigh,


		}

	}
}
