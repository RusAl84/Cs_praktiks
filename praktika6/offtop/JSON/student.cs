using System;

[Serializable]
public class student
{
	private string name;
	private int course;

	public student()
	{
		Name = "";
		Course = 2;
	}

	public student(string name, int course)
	{
		Name = name;
		Course = course;
	}

	public string Name
	{
		get { return name; }
		set { if (value.Length < 1) {
				name = "Valera";
			} 
		else
			{
				name = value;
			}
		}
	}
	public int Course
	{
		 get { return course; }
		set {
			if (value <= 1)
			{
				course = 1;
			}else
			if (value >= 5)
			{
				course = 5;
			}
			else
			{
				course = value;
			}
		}
	}

	public override string ToString()
	{
		return $"Имя: {name}  учится на {course} курсе ";
	}

}
