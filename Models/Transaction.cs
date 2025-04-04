using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerMVC.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }

		public int CategotyId { get; set; }
		public Category Category { get; set; } // nevigational proprties 
		public int Amount { get; set; }
		[Column(TypeName = "nvarchar(75)")]
		public string? Note { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;
	}
}
