﻿using ModelHelper;
using System.ComponentModel.DataAnnotations;

namespace Log.Data;

public class Place 
	: IModelA
{
	public int Id { get; set; }

	[Required]
	[MaxLength(25)]
	public string Name { get; set; }

	[Required]
	[MaxLength(70)]
	public string Description { get; set; }
}