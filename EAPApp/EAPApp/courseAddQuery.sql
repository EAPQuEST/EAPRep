

insert into college_coures(collegeid,courseid) values((select college_id from college_details where college_name='frg'),(select course_id from course_details where course_name='Computer Science and Engineering'))

