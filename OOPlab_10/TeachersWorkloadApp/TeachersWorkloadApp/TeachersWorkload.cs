public class TeachersWorkload
{
    public int TeacherId { get; set; }
    public string TeacherName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public int Hours { get; set; }

    public TeachersWorkload(int teacherId, string teacherName, string subject, int hours)
    {
        TeacherId = teacherId;
        TeacherName = teacherName;
        Subject = subject;
        Hours = hours;
    }

    public override string ToString()
    {
        return $"ID: {TeacherId}, Name: {TeacherName}, Subject: {Subject}, Hours: {Hours}";
    }
}
