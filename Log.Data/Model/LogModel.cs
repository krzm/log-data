using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Log.Data;

public class LogModel
{
	public int Id { get; set; }

	[ForeignKey("Task")]
	public int TaskId { get; set; }

	[Required]
	[Column(TypeName = "datetime2")]
	public DateTime Start { get; set; }

	[Column(TypeName = "datetime2")]
	public DateTime? End { get; set; }

	[MaxLength(70)]
	public string Description { get; set; }

	[ForeignKey("Place")]
	public int PlaceId { get; set; }

	public long? TimeTicks { get; set; }

	public Task Task { get; set; }

	public Place Place { get; set; }

	[NotMapped]
	public TimeSpan Time
	{
		get { return TimeSpan.FromTicks(TimeTicks ?? default); }
		set { TimeTicks = value.Ticks; }
	}
}