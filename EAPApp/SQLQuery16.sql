﻿select candidate_id,course_id,reservation,status from allotment where college_id='SCMS123' and status='Alloted' or status='confirmed' and candidate_id like ' %'