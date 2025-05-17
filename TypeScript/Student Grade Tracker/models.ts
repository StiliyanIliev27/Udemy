enum Subject {
  Math = "Math",
  English = "English",
  Geography = "Geography",
  History = "History",
  ImformationTechnology = "Information Technology",
  Biology = "Biology",
  Chemistry = "Chemistry",
  PhysicalEducation = "Physical Education",
}

interface IGrade {
  subject: Subject;
  score: number;
}

interface IStudent {
  firstName: string;
  lastName: string;
  grades: IGrade[];

  addGrade(subject: Subject, score: number): void;
  averageGrade(): number;
  getSummary(): string;
}

class Student implements IStudent {
  constructor(
    public firstName: string,
    public lastName: string,
    public grades: IGrade[] = []
  ) {}

  addGrade(subject: Subject, score: number): void {
    this.grades.push({ subject, score });
  }

  averageGrade(): number {
    const total = this.grades.reduce((sum, grade) => sum + grade.score, 0);
    return this.grades.length ? total / this.grades.length : 0;
  }

  getSummary(): string {
    return `Student: ${this.firstName} ${this.lastName} - Average Grade: ${this.averageGrade().toFixed(2)}`;
  }
}

class School {
  constructor(private name: string, private students: Student[] = []){}

  set schoolName(name: string){
    if(!name.trim()){
      throw new Error('School name is not valid!');
    }

    this.name = name.trim();
  }

  get studentsCount(): number{
    return this.students.length;
  }

  get getStudents(): Student[]{
    return this.students;
  }

  addStudent(student: Student): void{
    this.students.push(student);
  }

  showSummary(): string {
    const summaryLines = [
      `School: ${this.name} - Students Count: ${this.studentsCount}`,
      'Students:'
    ];
  
    this.students.forEach((s, i) => {
      summaryLines.push(`${i + 1}. ${s.getSummary()}`);
    });
  
    return summaryLines.join('\n');
  }
}


export {
  School, 
  Student,
  Subject
}