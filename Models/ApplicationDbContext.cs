﻿using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerMVC.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
		{
		}
		public  DbSet<Transaction> Transactions { get; set; }
		public  DbSet<Category> Categories { get; set; }
	}
}
