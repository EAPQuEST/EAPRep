﻿select course_name from course_details where course_id IN(SELECT  college_coures.courseid FROM college_coures WHERE collegeid ='hgeyu')