import SchoolManagementSystem from './engine';

class MySchoolSystem extends SchoolManagementSystem { }

SchoolManagementSystem.welcome();
SchoolManagementSystem.rules();

const app = new MySchoolSystem();
app.run();