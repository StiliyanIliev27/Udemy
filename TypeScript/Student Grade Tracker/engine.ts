import * as readlineSync from "readline-sync";
import { Subject, School, Student } from "./models";

enum MenuOption {
  AddStudent = "Add student",
  AddGrade = "Add grade",
  ShowSummary = "Show summary",
  Exit = "Exit",
}

type StudentInputModel = {
  firstName: string;
  lastName: string;
  school: string;
};

interface IRunnable {
  run(): void;
}

abstract class SchoolManagementSystem implements IRunnable {
  constructor(public schools: School[] = []) {}

  static welcome() {
    console.log("Welcome to the School Management System!");
  }

  static rules() {
    console.log(
      "You should enter the text only (e.g Add student, Add grade, etc.) !"
    );
    console.log(
      `1. ${MenuOption.AddStudent}
       2. ${MenuOption.AddGrade}
       3. ${MenuOption.ShowSummary}
       4. ${MenuOption.Exit}`
    );
  }

  run(): void {
    let line = readlineSync.question();

    while (line != MenuOption.Exit) {
      switch (line) {
        case MenuOption.AddStudent:
          const firstName: string = readlineSync.question("First Name: ");
          const lastName: string = readlineSync.question("Last name: ");
          const school: string = readlineSync.question("School: ");

          const studentModel: StudentInputModel = {
            firstName: firstName,
            lastName: lastName,
            school: school,
          };

          this.enterStudent(studentModel);
          break;
        case MenuOption.AddGrade:
          // Show subject list
          console.log("Choose a subject:");
          const subjectOptions = Object.values(Subject);
          subjectOptions.forEach((subj, i) => console.log(`${i + 1}. ${subj}`));

          const subjectIndex = readlineSync.questionInt("Enter number: ") - 1;

          // Validate choice
          if (subjectIndex < 0 || subjectIndex >= subjectOptions.length) {
            console.log("Invalid subject choice!");
            break;
          }

          const chosenSubject = subjectOptions[subjectIndex];
          const score: number = readlineSync.questionFloat("Grade: ");

          // Proceed to grade entry
          this.enterGrade(chosenSubject, score);
          break;
        case MenuOption.ShowSummary:
          this.schools.forEach((school) => {
            console.log(school.showSummary());
            console.log("");
          });
          break;
        default:
          console.log("Invalid input! Try again!");
          break;
      }

      line = readlineSync.question();
    }
  }

  private enterStudent(studentModel: StudentInputModel): void {
    const student = new Student(studentModel.firstName, studentModel.lastName);

    let school = this.schools.find((s) => s.schoolName === studentModel.school);

    if (!school) {
      school = new School(studentModel.school);
      this.schools.push(school);
    }

    school.addStudent(student);
  }

  private enterGrade(subject: Subject, score: number): void {
    const firstName = readlineSync.question("Enter student's first name: ");
    const lastName = readlineSync.question("Enter student's last name: ");

    let studentFound: Student | undefined;

    for (const school of this.schools) {
      studentFound = school.getStudents.find(
        (s) => s.firstName === firstName && s.lastName === lastName
      );
      if (studentFound) break;
    }

    if (!studentFound) {
      console.log("Student not found.");
      return;
    }

    studentFound.addGrade(subject, score);
    console.log(`Grade added for ${firstName} ${lastName}`);
  }
}

export default SchoolManagementSystem;
