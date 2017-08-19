var gulp = require("gulp");
var fs = require("fs");
var sass = require("gulp-sass");


gulp.task("sass", function () {
    return gulp.src("Sass/text.scss")
        .pipe(sass())
        .pipe(gulp.destination("wwwroot/css"));
});