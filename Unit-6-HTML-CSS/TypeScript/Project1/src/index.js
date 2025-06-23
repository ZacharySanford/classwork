// typescript file goes here
console.log("Welcome to my first TypeScript Program");
var Roster = /** @class */ (function () {
    function Roster() {
        this.studentList = [];
    }
    Roster.prototype.addStudent = function (newStudent) {
        this.studentList.push(newStudent);
    };
    Roster.prototype.getAllTheStudents = function () {
        return this.studentList;
    };
    return Roster;
}());
var classRoster = new Roster();
classRoster.addStudent({ studentName: "Frank", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Zach", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "India", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Kiana", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Youssef", className: "of his own", startDate: 20260623 });
classRoster.getAllTheStudents().forEach(function (aStudent) { console.log(aStudent); });
