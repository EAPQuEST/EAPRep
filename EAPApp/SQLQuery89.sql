SELECT course_details.course_name, 
  FROM course_details
  WHERE course_details.course_id=(SELECT college_coures.courseid
              FROM college_coures
              WHERE college_coures.collegeid=(SELECT college_details.college_id
											FROM college_details
											WHERE college_details.college_name='hmm'));