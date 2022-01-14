using Core.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Log.Data;

public class Task : IModelA
{
	public int Id { get; set; }

	[Required]
	[MaxLength(25)]
	public string Name { get; set; }

	[Required]
	[MaxLength(70)]
	public string Description { get; set; }

	[ForeignKey("Category")]
	public int CategoryId { get; set; }

	public Category Category { get; set; }
}