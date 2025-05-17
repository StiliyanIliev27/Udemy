"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || (function () {
    var ownKeys = function(o) {
        ownKeys = Object.getOwnPropertyNames || function (o) {
            var ar = [];
            for (var k in o) if (Object.prototype.hasOwnProperty.call(o, k)) ar[ar.length] = k;
            return ar;
        };
        return ownKeys(o);
    };
    return function (mod) {
        if (mod && mod.__esModule) return mod;
        var result = {};
        if (mod != null) for (var k = ownKeys(mod), i = 0; i < k.length; i++) if (k[i] !== "default") __createBinding(result, mod, k[i]);
        __setModuleDefault(result, mod);
        return result;
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
const readlineSync = __importStar(require("readline-sync"));
const models_1 = require("./models");
var MenuOption;
(function (MenuOption) {
    MenuOption["AddStudent"] = "Add student";
    MenuOption["AddGrade"] = "Add grade";
    MenuOption["ShowSummary"] = "Show summary";
    MenuOption["Exit"] = "Exit";
})(MenuOption || (MenuOption = {}));
class SchoolManagementSystem {
    schools;
    constructor(schools = []) {
        this.schools = schools;
    }
    static welcome() {
        console.log("Welcome to the School Management System!");
    }
    static rules() {
        console.log("You should enter the text only (e.g Add student, Add grade, etc.) !");
        console.log(`1. ${MenuOption.AddStudent}
       2. ${MenuOption.AddGrade}
       3. ${MenuOption.ShowSummary}
       4. ${MenuOption.Exit}`);
    }
    run() {
        let line = readlineSync.question();
        while (line != MenuOption.Exit) {
            switch (line) {
                case MenuOption.AddStudent:
                    const firstName = readlineSync.question("First Name: ");
                    const lastName = readlineSync.question("Last name: ");
                    const school = readlineSync.question("School: ");
                    const studentModel = {
                        firstName: firstName,
                        lastName: lastName,
                        school: school,
                    };
                    this.enterStudent(studentModel);
                    break;
                case MenuOption.AddGrade:
                    // Show subject list
                    console.log("Choose a subject:");
                    const subjectOptions = Object.values(models_1.Subject);
                    subjectOptions.forEach((subj, i) => console.log(`${i + 1}. ${subj}`));
                    const subjectIndex = readlineSync.questionInt("Enter number: ") - 1;
                    // Validate choice
                    if (subjectIndex < 0 || subjectIndex >= subjectOptions.length) {
                        console.log("Invalid subject choice!");
                        break;
                    }
                    const chosenSubject = subjectOptions[subjectIndex];
                    const score = readlineSync.questionFloat("Grade: ");
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
    enterStudent(studentModel) {
        const student = new models_1.Student(studentModel.firstName, studentModel.lastName);
        let school = this.schools.find((s) => s.schoolName === studentModel.school);
        if (!school) {
            school = new models_1.School(studentModel.school);
            this.schools.push(school);
        }
        school.addStudent(student);
    }
    enterGrade(subject, score) {
        const firstName = readlineSync.question("Enter student's first name: ");
        const lastName = readlineSync.question("Enter student's last name: ");
        let studentFound;
        for (const school of this.schools) {
            studentFound = school.getStudents.find((s) => s.firstName === firstName && s.lastName === lastName);
            if (studentFound)
                break;
        }
        if (!studentFound) {
            console.log("Student not found.");
            return;
        }
        studentFound.addGrade(subject, score);
        console.log(`Grade added for ${firstName} ${lastName}`);
    }
}
exports.default = SchoolManagementSystem;
