using System;
using System.Collections.Generic;

namespace EF1.Data.Models;

public partial class Lecture
{
    public int Id { get; set; }

    public string LectureRoom { get; set; } = null!;

    public int? SubjectId { get; set; }

    public int? TeacherId { get; set; }

    public virtual ICollection<GroupsLecture> GroupsLectures { get; } = new List<GroupsLecture>();

    public virtual Subject? Subject { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
