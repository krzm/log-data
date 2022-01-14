using Core.Model;
using System.ComponentModel.DataAnnotations;

namespace Log.Data;

public class Category 
	: IModelA
{
	public int Id { get; set; }

	[Required, MaxLength(25)]
	public string Name { get; set; }

	[Required, MaxLength(70)]
	public string Description { get; set; }
}