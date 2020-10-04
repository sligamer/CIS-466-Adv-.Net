-- parameter query
SELECT        Id, TutorialName, TutorialNumber, TutorialDescription, TutorialSteps, TutorialTime
FROM            FinalProjectData 
Where TutorialName Like '%' + @criteria + '%' 
OR TutorialNumber Like '%' + @criteria + '%' 
OR TutorialDescription Like '%' + @criteria + '%'