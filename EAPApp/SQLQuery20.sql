

select candiate_physics+candiate_chemistry+candiate_maths+(select entrance_science_mark+entrance_maths_mark from entrance_details where entrance_id='101') from candidate_details where candidate_id='601'