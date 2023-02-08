using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class GroupsLecture
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? LectureId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Lecture? Lecture { get; set; }
}
