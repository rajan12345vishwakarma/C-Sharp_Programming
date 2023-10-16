UPDATE students
SET gender = CASE 
WHEN gender = 'M' THEN 'F'
WHEN gender = 'F' THEN 'M'
ELSE NULL
END 
