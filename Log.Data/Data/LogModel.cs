using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Log.Data;

public class LogModel
{
    private const string Datetime2Name = "datetime2";

    public int Id { get; set; }

	[ForeignKey(nameof(Task))]
	public int TaskId { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? Start { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? End { get; set; }

	[MaxLength(70)]
	public string? Description { get; set; }

	[ForeignKey(nameof(Place))]
	public int PlaceId { get; set; }

	public long? TimeTicks { get; set; }

	public Task? Task { get; set; }

	public Place? Place { get; set; }

	[NotMapped]
	public TimeSpan Time
	{
		get { return TimeSpan.FromTicks(TimeTicks ?? default); }
		set { TimeTicks = value.Ticks; }
	}
}