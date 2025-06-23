// typescript file goes here
console.log("Welcome to my first TypeScript Program")

interface Student {
    studentName : string;
    className : string;
    startDate : number;
}

class Roster {
    studentList : Student[];
    constructor() {
        this.studentList = [];
    }

    addStudent(newStudent : Student){
        this.studentList.push(newStudent)
    }

    getAllTheStudents(){
        return this.studentList;
    }
}

let classRoster = new Roster();

classRoster.addStudent({studentName : "Frank", className: "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Zach", className: "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "India", className: "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Kiana", className: "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Youssef", className: "of his own", startDate : 20260623})

classRoster.getAllTheStudents().forEach(aStudent => {console.log(aStudent)})