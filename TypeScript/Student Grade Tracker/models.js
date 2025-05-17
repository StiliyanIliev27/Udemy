"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Subject = exports.Student = exports.School = void 0;
var Subject;
(function (Subject) {
    Subject["Math"] = "Math";
    Subject["English"] = "English";
    Subject["Geography"] = "Geography";
    Subject["History"] = "History";
    Subject["ImformationTechnology"] = "Information Technology";
    Subject["Biology"] = "Biology";
    Subject["Chemistry"] = "Chemistry";
    Subject["PhysicalEducation"] = "Physical Education";
})(Subject || (exports.Subject = Subject = {}));
class Student {
    firstName;
    lastName;
    grades;
    constructor(firstName, lastName, grades = []) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.grades = grades;
    }
    addGrade(subject, score) {
        this.grades.push({ subject, score });
    }
    averageGrade() {
        const total = this.grades.reduce((sum, grade) => sum + grade.score, 0);
        return this.grades.length ? total / this.grades.length : 0;
    }
    getSummary() {
        return `Student: ${this.firstName} ${this.lastName} - Average Grade: ${this.averageGrade().toFixed(2)}`;
    }
}
exports.Student = Student;
class School {
    name;
    students;
    constructor(name, students = []) {
        this.name = name;
        this.students = students;
    }
    set schoolName(name) {
        if (!name.trim()) {
            throw new Error('School name is not valid!');
        }
        this.name = name.trim();
    }
    get studentsCount() {
        return this.students.length;
    }
    get getStudents() {
        return this.students;
    }
    addStudent(student) {
        this.students.push(student);
    }
    showSummary() {
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
exports.School = School;
