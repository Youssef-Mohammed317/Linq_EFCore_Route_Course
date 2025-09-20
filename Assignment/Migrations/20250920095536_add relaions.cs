using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class addrelaions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_CourseId",
                table: "Student_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                schema: "dbo",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_InstructorId",
                schema: "dbo",
                table: "Course_Inst",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Courses_InstructorId",
                schema: "dbo",
                table: "Course_Inst",
                column: "InstructorId",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructors_CourseId",
                schema: "dbo",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                schema: "dbo",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_Courses_CourseId",
                table: "Student_Courses",
                column: "CourseId",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_Students_StudentId",
                table: "Student_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Courses_InstructorId",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructors_CourseId",
                schema: "dbo",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_Courses_CourseId",
                table: "Student_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_Students_StudentId",
                table: "Student_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Student_Courses_CourseId",
                table: "Student_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_InstructorId",
                schema: "dbo",
                table: "Course_Inst");
        }
    }
}
