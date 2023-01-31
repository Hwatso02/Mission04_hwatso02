//button
$("#btnCalculate").click(function () {

//calculate overall percentage grade
percentage =(($("#Assignments").val() * 0.5) + ($("#GroupProject").val() * 0.1) + ($("#Quizzes").val() * 0.1)
        + ($("#MidtermExam").val() * 0.1) + ($("#FinalExam").val() * 0.1) + ($("#Intex").val() * 0.1))

//loop through sum to get letter grade
if (percentage >= 94) {
    grades = "A";
} else if (percentage < 94 && percentage >= 90) {
    grades = "A-";
} else if (percentage < 90 && percentage >= 87) {
    grades = "B+";
} else if (percentage < 87 && percentage >= 84) {
    grades = "B";
} else if (percentage < 84 && percentage >= 80) {
    grades = "B-";
} else if (percentage < 80 && percentage >= 77) {
    grades = "C+";
} else if (percentage < 77 && percentage >= 74) {
    grades = "C";
} else if (percentage < 74 && percentage >= 70) {
    grades = "C-";
} else if (percentage < 70 && percentage >= 67) {
    grades = "D+";
} else if (percentage < 67 && percentage >= 64) {
    grades = "D";
} else if (percentage < 64 && percentage >= 60) {
    grades = "D-";
} else if (percentage < 60) {
    grades = "E";
}
    //assign letter grade into html
    $("#grade").html(grades)
})