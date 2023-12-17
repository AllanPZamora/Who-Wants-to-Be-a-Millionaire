Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Game
    Private currentQuestionIndex As Integer = 0
    Private questions As List(Of Question) = New List(Of Question)()
    Private answerButtons As List(Of Button)
    Private rand As New Random()

    Private Sub InitializeQuestions()

        Select Case My.Settings.categoryStr

            Case "Accountancy"

                questions.Add(New Question("What is the primary purpose of financial accounting?", {"Internal decision-making", "Reporting financial information to external parties", "Budgeting and forecasting", "Tax planning"}, 1))
                questions.Add(New Question("In accounting, what does the term 'GAAP' stand for?", {"Generally Accepted Accounting Procedures", "Generally Accepted Accounting Principles", "Global Accounting and Auditing Practices", "General Analysis of Accounting Procedures"}, 1))
                questions.Add(New Question("What is the primary goal of managerial accounting?", {"Complying with tax regulations", "Providing information for internal decision-making", "Creating financial statements", "Auditing financial records"}, 1))
                questions.Add(New Question("What does the term 'double-entry accounting' mean?", {"Recording transactions twice for accuracy", "Entering data into accounting software", "Managing two separate sets of books", "Conducting two separate audits"}, 0))
                questions.Add(New Question("In accounting, what is the formula for calculating net income?", {"Revenue - Expenses", "Assets - Liabilities", "Income - Taxes", "Revenue - Cost of Goods Sold - Expenses"}, 3))
                questions.Add(New Question("What is the purpose of a balance sheet in accounting?", {"Summarizing revenue and expenses", "Showing the financial position of a company at a specific point in time", "Detailing cash transactions", "Analyzing cost behavior"}, 1))
                questions.Add(New Question("What is the term for the systematic allocation of the cost of an intangible asset over its useful life?", {"Depreciation", "Amortization", "Depletion", "Impairment"}, 1))
                questions.Add(New Question("What is the main purpose of an income statement in accounting?", {"Reporting assets and liabilities", "Presenting revenues, expenses, and net income over a specific period", "Detailing cash flows", "Summarizing owner's equity"}, 1))
                questions.Add(New Question("What does the term 'cash flow statement' represent in accounting?", {"A record of cash transactions", "The movement of cash into and out of a business over a specific period", "Bank account reconciliation", "Cash budgeting"}, 1))
                questions.Add(New Question("In accounting, what is the formula for calculating the quick ratio?", {"(Current Assets - Inventory) / Current Liabilities", "Current Assets / Current Liabilities", "(Current Assets + Inventory) / Current Liabilities", "Current Assets - Current Liabilities"}, 0))
                questions.Add(New Question("What is the purpose of the Generally Accepted Auditing Standards (GAAS) in accounting?", {"Establishing accounting principles", "Providing guidelines for auditing procedures", "Standardizing financial reporting formats", "Determining tax regulations"}, 1))
                questions.Add(New Question("What is the term for the cost of acquiring or producing a product for resale?", {"Operating expenses", "Cost of Goods Sold (COGS)", "Overhead costs", "General and administrative expenses"}, 1))
                questions.Add(New Question("In accounting, what does the term 'accrual' mean?", {"Recording transactions in real-time", "Recognizing revenue or expenses before the actual cash transaction occurs", "Adjusting entries at the end of a period", "Delaying the recognition of income"}, 1))
                questions.Add(New Question("What is the purpose of the Sarbanes-Oxley Act in accounting?", {"Regulating tax codes", "Enhancing corporate governance and financial disclosures", "Standardizing international accounting practices", "Setting rules for managerial accounting"}, 1))
                questions.Add(New Question("What is the term for a financial statement that shows changes in equity over a specific period?", {"Income statement", "Statement of Cash Flows", "Statement of Changes in Equity", "Balance sheet"}, 2))
                questions.Add(New Question("What is the primary goal of internal controls in accounting?", {"Ensuring compliance with tax laws", "Safeguarding assets and enhancing the accuracy of financial information", "Minimizing expenses", "Maximizing profits"}, 1))
                questions.Add(New Question("What does the term 'depreciation' involve in accounting?", {"Allocating the cost of a tangible asset over its useful life", "Increasing the value of an asset", "Recording the initial cost of an asset", "Adjusting financial statements at the end of a period"}, 0))
                questions.Add(New Question("In accounting, what is the term for a temporary account used to close revenue and expense accounts at the end of an accounting period?", {"Balance sheet", "Income summary", "Retained earnings", "Cash flow statement"}, 1))
                questions.Add(New Question("What is the purpose of the International Financial Reporting Standards (IFRS) in accounting?", {"Regulating internal controls", "Harmonizing global accounting practices", "Setting tax rates", "Standardizing auditing procedures"}, 1))
                questions.Add(New Question("What is the term for the process of comparing financial information with industry averages or competitors?", {"Financial analysis", "Benchmarking", "Ratio analysis", "Trend analysis"}, 1))
                questions.Add(New Question("In accounting, what does the term 'working capital' represent?", {"The ability to generate profit", "Current assets minus current liabilities", "Total assets minus total liabilities", "The difference between revenue and expenses"}, 1))
                questions.Add(New Question("What is the purpose of the Statement of Cash Flows in accounting?", {"Presenting changes in equity", "Detailing the sources and uses of cash during a specific period", "Summarizing financial position at a specific point in time", "Analyzing cost behavior"}, 1))
                questions.Add(New Question("What is the term for a legal entity that is separate and distinct from its owners in accounting?", {"Sole proprietorship", "Partnership", "Corporation", "Limited liability company"}, 2))
                questions.Add(New Question("What does the term 'accounting cycle' involve?", {"The process of creating financial statements", "The sequence of accounting procedures from analyzing transactions to closing the books", "The cycle of economic activities in a business", "The annual financial reporting period"}, 1))
                questions.Add(New Question("In accounting, what does the term 'liquidity' refer to?", {"The ability to pay short-term debts", "The speed of accounting transactions", "The availability of cash for investment", "The efficiency of inventory management"}, 0))
                questions.Add(New Question("What is the term for a financial ratio that measures a company's ability to cover its short-term obligations with its most liquid assets?", {"Current ratio", "Quick ratio", "Debt-to-equity ratio", "Return on investment"}, 1))
                questions.Add(New Question("What is the primary purpose of the Statement of Retained Earnings in accounting?", {"Detailing changes in equity over time", "Showing the distribution of profits to shareholders", "Explaining the changes in the retained earnings account during a specific period", "Presenting the financial position of a company"}, 2))
                questions.Add(New Question("What is the term for the cost incurred for using up or consuming the economic benefits of an asset in accounting?", {"Depreciation", "Amortization", "Depletion", "Expense"}, 3))
                questions.Add(New Question("In accounting, what does the term 'journal entry' involve?", {"A summary of financial transactions", "The recording of a business transaction in the accounting system", "A formal financial statement", "A report of cash transactions"}, 1))
                questions.Add(New Question("What is the purpose of the Trial Balance in accounting?", {"Summarizing financial transactions", "Verifying the equality of debits and credits in the general ledger", "Analyzing financial ratios", "Detailing changes in equity over a specific period"}, 1))
                questions.Add(New Question("What does the term 'FIFO' stand for in inventory valuation?", {"First In, First Out", "Fast Inventory Flow Optimization", "Final Inventory Forecast Outcome", "Financial Inventory Fundamentals Oversight"}, 0))
                questions.Add(New Question("In accounting, what is the purpose of the 'matching principle'?", {"Matching expenses with the revenue they generate", "Matching assets with liabilities", "Matching current ratios with quick ratios", "Matching debits with credits"}, 0))
                questions.Add(New Question("What is the term for the financial statement that summarizes a company's revenues and expenses over a specific period?", {"Balance sheet", "Income statement", "Statement of Retained Earnings", "Cash flow statement"}, 1))
                questions.Add(New Question("What does the term 'CPA' stand for in accounting?", {"Certified Public Auditor", "Certified Professional Accountant", "Certified Public Accountant", "Chartered Professional Auditor"}, 2))
                questions.Add(New Question("What is the purpose of the audit trail in accounting software?", {"Verifying employee time records", "Providing a record of changes to accounting data for accountability and accuracy", "Tracking inventory levels", "Documenting customer complaints and resolutions"}, 1))

            Case "Crim"

                questions.Add(New Question("What is criminology?", {"Study of crime and its causes", "Study of cooking techniques", "Study of ancient civilizations", "Study of plant life"}, 0))
                questions.Add(New Question("Who is often considered the father of modern criminology?", {"Karl Marx", "Emile Durkheim", "Cesare Beccaria", "Jeremy Bentham"}, 3))
                questions.Add(New Question("What is the broken windows theory in criminology?", {"Theory of shattered glass", "Theory of disorder leading to crime", "Theory of broken relationships", "Theory of window maintenance"}, 1))
                questions.Add(New Question("Which of the following is NOT a biological theory of crime?", {"Lombroso's atavism theory", "Sheldon's somatotype theory", "Social learning theory", "Y-chromosome theory"}, 2))
                questions.Add(New Question("What is the main focus of white-collar criminology?", {"Street crimes", "Corporate crimes", "Homicides", "Cybercrimes"}, 1))
                questions.Add(New Question("What does the acronym FBI stand for?", {"Federal Bureau of Investigation", "Foreign Business Initiatives", "Financial Banking Institution", "Forensic Behavioral Institute"}, 0))
                questions.Add(New Question("Which criminological theory emphasizes the role of social bonds in preventing criminal behavior?", {"Strain theory", "Social control theory", "Routine activity theory", "Labeling theory"}, 1))
                questions.Add(New Question("What is the 'dark figure of crime'?", {"Crimes committed at night", "Unreported or undiscovered crime", "Crimes involving dark motives", "Crimes committed by unknown individuals"}, 1))
                questions.Add(New Question("Which of the following is an example of a crime against property?", {"Assault", "Robbery", "Vandalism", "Kidnapping"}, 2))
                questions.Add(New Question("What is the term for a legal defense where the defendant admits to the crime but argues it was necessary to prevent a greater harm?", {"Insanity defense", "Duress defense", "Justification defense", "Alibi defense"}, 2))
                questions.Add(New Question("What is the primary goal of restorative justice?", {"Retribution", "Rehabilitation", "Restoration", "Deterrence"}, 2))
                questions.Add(New Question("Which crime involves using a computer to commit an offense, such as hacking or identity theft?", {"Cyberbullying", "Cybercrime", "Cyberstalking", "Cyberwarfare"}, 1))
                questions.Add(New Question("What does the term 'recidivism' refer to in criminology?", {"First-time offenders", "Repeat criminal behavior", "Criminal rehabilitation", "Criminal profiling"}, 1))
                questions.Add(New Question("Who developed the social learning theory of crime?", {"Albert Bandura", "Sigmund Freud", "Erik Erikson", "B.F. Skinner"}, 0))
                questions.Add(New Question("What is the primary focus of environmental criminology?", {"Biological factors in crime", "Economic factors in crime", "Physical and social environments influencing crime", "Psychological factors in crime"}, 2))
                questions.Add(New Question("In criminology, what is the term for a crime committed by a person of respectability and high social status in the course of their occupation?", {"Organized crime", "Street crime", "White-collar crime", "Blue-collar crime"}, 2))
                questions.Add(New Question("What is the purpose of a criminal profile in forensic psychology?", {"To determine the guilt of a suspect", "To identify potential motives", "To create a behavioral description of an offender", "To assess witness credibility"}, 2))
                questions.Add(New Question("What is the focus of the strain theory of crime?", {"Lack of moral development", "Conflict between social classes", "Inequality and societal pressure", "Genetic predisposition to crime"}, 2))
                questions.Add(New Question("Which U.S. Supreme Court case established the 'Miranda rights' for suspects?", {"Gideon v. Wainwright", "Miranda v. Arizona", "Brown v. Board of Education", "Roe v. Wade"}, 1))
                questions.Add(New Question("What is the 'crime funnel' concept in criminal justice?", {"Gradual increase in criminal activity", "Decrease in crime rates over time", "Reduction in the number of cases from initial report to final disposition", "Criminal profiling technique"}, 2))
                questions.Add(New Question("What is the purpose of the juvenile justice system?", {"Retribution", "Rehabilitation", "Deterrence", "Restitution"}, 1))
                questions.Add(New Question("What is the difference between jail and prison?", {"Jail is for long-term sentences, while prison is for short-term sentences.", "Jail is run by federal authorities, while prison is run by state authorities.", "Jail is for short-term sentences, while prison is for long-term sentences.", "Jail and prison are interchangeable terms."}, 2))
                questions.Add(New Question("What is the primary focus of the routine activity theory of crime?", {"Social bonds", "Everyday activities and opportunities for crime", "Psychological factors", "Economic inequality"}, 1))
                questions.Add(New Question("What is the 'blue code of silence' in law enforcement?", {"Code for undercover operations", "Code of ethics for officers", "Unwritten rule of not reporting misconduct by fellow officers", "Code for emergency situations"}, 2))
                questions.Add(New Question("Which amendment to the U.S. Constitution protects against unreasonable searches and seizures?", {"First Amendment", "Fourth Amendment", "Eighth Amendment", "Tenth Amendment"}, 1))
                questions.Add(New Question("What is the 'bystander effect' in the context of crime?", {"People who witness a crime but don't intervene", "The tendency to report crimes only anonymously", "The influence of media on crime rates", "The impact of crime on bystanders' mental health"}, 0))
                questions.Add(New Question("What is the primary goal of punishment in the criminal justice system?", {"Retribution", "Rehabilitation", "Deterrence", "Restoration"}, 0))
                questions.Add(New Question("What is the term for a crime committed against the state or government?", {"Treason", "Sedition", "Espionage", "Sabotage"}, 0))
                questions.Add(New Question("What is the 'crime control model' in criminal justice?", {"Emphasis on protecting individual rights", "Emphasis on crime prevention and punishment", "Emphasis on rehabilitation", "Emphasis on restorative justice"}, 1))
                questions.Add(New Question("What is the primary goal of community policing?", {"Reactive response to crime", "Building positive relationships between police and the community", "Strict enforcement of laws", "Eliminating crime through surveillance"}, 1))
                questions.Add(New Question("What is the purpose of the National Crime Information Center (NCIC) in the United States?", {"To conduct criminal investigations", "To provide legal representation for suspects", "To maintain a database of criminal information", "To oversee parole and probation programs"}, 2))
                questions.Add(New Question("What is the term for a false statement that damages a person's reputation?", {"Libel", "Slander", "Defamation", "Invasion of privacy"}, 1))

            Case "Educ"

                questions.Add(New Question("What does STEM stand for in the context of education?", {"Science, Teaching, English, Mathematics", "Social Studies, Technology, Engineering, Mathematics", "Science, Technology, Engineering, Mathematics", "Society, Teaching, Ethics, Music"}, 2))
                questions.Add(New Question("Who is considered the father of modern education?", {"Plato", "Socrates", "John Dewey", "Aristotle"}, 2))
                questions.Add(New Question("In the field of psychology, which theory emphasizes the importance of self-efficacy in learning?", {"Behaviorism", "Constructivism", "Social Cognitive Theory", "Humanism"}, 2))
                questions.Add(New Question("What is the main focus of special education?", {"Gifted and talented students", "Inclusive classrooms", "Students with disabilities", "Advanced placement programs"}, 2))
                questions.Add(New Question("What does the term 'differentiated instruction' mean in education?", {"Teaching different subjects in one class", "Adapting teaching methods to meet individual student needs", "Providing extra homework for advanced students", "Standardizing curriculum across schools"}, 1))
                questions.Add(New Question("Who is known for the theory of multiple intelligences in education?", {"Jean Piaget", "Howard Gardner", "Lev Vygotsky", "Erik Erikson"}, 1))
                questions.Add(New Question("What does the acronym ESL stand for in education?", {"Extra Student Learning", "English as a Second Language", "Early Science Learning", "Effective Study and Learning"}, 1))
                questions.Add(New Question("In education, what does the term 'pedagogy' refer to?", {"Classroom management", "The art and science of teaching", "Student assessment", "Educational technology"}, 1))
                questions.Add(New Question("What is the purpose of the Common Core State Standards in the United States?", {"Standardized testing", "A set of academic standards to guide K-12 education", "School funding allocation", "Teacher certification requirements"}, 1))
                questions.Add(New Question("Which educational philosophy emphasizes hands-on learning and real-world experiences?", {"Behaviorism", "Constructivism", "Essentialism", "Perennialism"}, 1))
                questions.Add(New Question("What is the primary focus of the Montessori method of education?", {"Strict discipline and rote memorization", "Child-led learning and self-discovery", "Standardized testing", "Team-based projects"}, 1))
                questions.Add(New Question("Who is considered the pioneer of progressive education in the early 20th century?", {"Maria Montessori", "John Dewey", "Rudolf Steiner", "Lev Vygotsky"}, 1))
                questions.Add(New Question("What is the primary goal of vocational education programs?", {"Academic excellence", "College preparation", "Skill development and job readiness", "Gifted education"}, 2))
                questions.Add(New Question("In higher education, what does the term 'tenure' mean?", {"A time-limited contract for professors", "Academic rank for senior faculty", "Permanent employment status with academic freedom", "A sabbatical leave for research"}, 2))
                questions.Add(New Question("What is the purpose of standardized testing in education?", {"Assessing teacher performance", "Measuring student achievement against a set standard", "Determining school funding", "Allocating resources based on test scores"}, 1))
                questions.Add(New Question("What is the primary focus of educational psychology?", {"Classroom management", "The study of how individuals learn and develop", "Assessment and testing", "Pedagogical techniques"}, 1))
                questions.Add(New Question("What is the term for a teaching method that tailors instruction to students' individual learning styles and preferences?", {"Differentiated instruction", "Personalized learning", "Cooperative learning", "Experiential learning"}, 1))
                questions.Add(New Question("What is the purpose of the No Child Left Behind Act (NCLB) in the United States?", {"Promoting standardized testing", "Closing achievement gaps and improving student performance", "Reducing teacher salaries", "Eliminating homework"}, 1))
                questions.Add(New Question("What is the primary focus of a school counselor?", {"Classroom instruction", "Student discipline", "Academic and personal development support", "School facility management"}, 2))
                questions.Add(New Question("What is the term for a teaching method that integrates two or more subjects to enhance learning?", {"Interdisciplinary instruction", "Single-subject focus", "Subject specialization", "Multidisciplinary teaching"}, 0))
                questions.Add(New Question("In educational technology, what does the acronym LMS stand for?", {"Learning Management System", "Language and Mathematics Software", "Lifelong Memory Storage", "Local Multimedia System"}, 0))
                questions.Add(New Question("What is the purpose of Title IX in education?", {"Equal access to sports opportunities for males and females", "Ensuring equal funding for all schools", "Implementing standardized testing", "Promoting school choice initiatives"}, 0))
                questions.Add(New Question("What does the term 'inclusion' mean in the context of special education?", {"Separate classrooms for students with disabilities", "Integrating students with disabilities into regular classrooms", "Gifted education programs", "Homeschooling"}, 1))
                questions.Add(New Question("What is the main focus of educational leadership programs?", {"Classroom instruction", "School administration and management", "Student counseling", "Teacher professional development"}, 1))
                questions.Add(New Question("In education, what does the term 'formative assessment' refer to?", {"Standardized testing", "Assessing student learning during instruction to provide feedback", "End-of-year exams", "Teacher evaluations"}, 1))
                questions.Add(New Question("What is the purpose of a teacher's union in education?", {"Advocating for higher student standards", "Negotiating employment contracts and protecting teachers' rights", "Standardizing curriculum", "Promoting school choice initiatives"}, 1))
                questions.Add(New Question("What does the term 'charter school' mean in education?", {"Private, for-profit schools", "Public schools with increased autonomy and flexibility", "Specialized schools for the arts", "Schools funded by charitable donations"}, 1))
                questions.Add(New Question("What is the purpose of the Individuals with Disabilities Education Act (IDEA) in the United States?", {"Promoting gifted education", "Ensuring equal access to education for all students with disabilities", "Funding school infrastructure projects", "Reducing teacher salaries"}, 1))
                questions.Add(New Question("What does the term 'blended learning' mean in education?", {"Combining various teaching methods in one lesson", "Teaching only through online platforms", "Implementing project-based learning", "Mixing students from different grades in one class"}, 0))
                questions.Add(New Question("What is the primary goal of early childhood education programs?", {"Academic achievement", "Social and emotional development", "Standardized testing preparation", "Classroom management skills"}, 1))
                questions.Add(New Question("What is the purpose of the Higher Education Act in the United States?", {"Regulating private schools", "Providing financial aid for students", "Establishing curriculum standards", "Increasing teacher salaries"}, 1))
                questions.Add(New Question("In educational research, what does the term 'correlational study' mean?", {"Experimental research design", "Analyzing relationships between variables without manipulation", "Longitudinal study", "Cross-sectional study"}, 1))
                questions.Add(New Question("What is the primary goal of multicultural education?", {"Promoting a single cultural perspective", "Integrating diverse cultural perspectives into the curriculum", "Eliminating cultural diversity", "Focusing solely on Western history and literature"}, 1))
                questions.Add(New Question("What does the term 'flipped classroom' mean in education?", {"Traditional lecture-based instruction", "Reversing the typical lecture and homework elements of a course", "Providing extra homework for advanced students", "Eliminating homework altogether"}, 1))
                questions.Add(New Question("What is the primary focus of the International Baccalaureate (IB) program in education?", {"Accelerated learning for gifted students", "Vocational education and skill development", "A globally focused, rigorous curriculum", "Physical education and sports training"}, 1))

            Case "Engi"

                questions.Add(New Question("What is civil engineering primarily concerned with?", {"Software development", "Building and maintaining infrastructure", "Aerospace technology", "Electrical circuit design"}, 1))
                questions.Add(New Question("In electrical engineering, what does AC stand for?", {"Advanced Circuits", "Alternating Current", "Amperes and Circuits", "Analog Computing"}, 1))
                questions.Add(New Question("What is the main focus of environmental engineering?", {"Electronics manufacturing", "Developing renewable energy sources", "Protecting and improving the environment", "Artificial intelligence"}, 2))
                questions.Add(New Question("What does the term 'aerospace engineering' encompass?", {"Designing and manufacturing aircraft and spacecraft", "Designing computer algorithms", "Building bridges and highways", "Developing medical devices"}, 0))
                questions.Add(New Question("In mechanical engineering, what is thermodynamics primarily concerned with?", {"Fluid mechanics", "Heat and energy transfer", "Material science", "Structural analysis"}, 1))
                questions.Add(New Question("What is the primary goal of industrial engineering?", {"Designing consumer products", "Optimizing processes and systems for efficiency", "Developing new materials", "Designing electronic circuits"}, 1))
                questions.Add(New Question("What is the purpose of a geotechnical engineer?", {"Designing computer networks", "Analyzing and designing structures based on soil and rock properties", "Developing medical imaging devices", "Programming artificial intelligence algorithms"}, 1))
                questions.Add(New Question("In computer engineering, what does the term 'CPU' stand for?", {"Central Processing Unit", "Computer Programming Unit", "Central Power Unit", "Computer Peripheral Unit"}, 0))
                questions.Add(New Question("What is the main focus of chemical engineering?", {"Designing electrical circuits", "Developing new materials and chemical processes", "Building bridges and highways", "Designing software applications"}, 1))
                questions.Add(New Question("What is the primary role of a structural engineer?", {"Developing software applications", "Designing and analyzing structures such as buildings and bridges", "Manufacturing electronic devices", "Designing medical equipment"}, 1))
                questions.Add(New Question("What is the purpose of a control engineer in automation systems?", {"Ensuring workplace safety", "Designing and implementing control systems for machines and processes", "Analyzing environmental impact", "Developing computer algorithms"}, 1))
                questions.Add(New Question("In aerospace engineering, what is the primary focus of avionics?", {"Aircraft design", "Electronic systems used in aircraft", "Aerodynamics", "Structural materials"}, 1))
                questions.Add(New Question("What does the term 'software engineering' involve?", {"Designing and developing computer programs and applications", "Civil infrastructure planning", "Environmental impact assessment", "Aerospace propulsion systems"}, 0))
                questions.Add(New Question("What is the main focus of biomedical engineering?", {"Designing computer hardware", "Developing medical devices and technologies", "Structural analysis of buildings", "Industrial process optimization"}, 1))
                questions.Add(New Question("What is the primary goal of systems engineering?", {"Developing computer networks", "Optimizing complex systems and processes", "Structural design of buildings", "Designing electrical circuits"}, 1))
                questions.Add(New Question("What is the term for the process of converting raw materials into usable products in manufacturing engineering?", {"Reverse engineering", "Materials engineering", "Production engineering", "Industrial automation"}, 2))
                questions.Add(New Question("In electrical engineering, what is Ohm's Law related to?", {"Magnetic fields", "Voltage, current, and resistance", "Thermodynamics", "Optical communication"}, 1))
                questions.Add(New Question("What is the primary focus of transportation engineering?", {"Traffic control systems", "Designing and planning transportation infrastructure", "Developing automotive technologies", "Urban planning"}, 1))
                questions.Add(New Question("In civil engineering, what does the term 'structural analysis' involve?", {"Analyzing environmental impact", "Assessing the strength and stability of structures", "Designing computer networks", "Materials testing"}, 1))
                questions.Add(New Question("What does the term 'robotics engineering' encompass?", {"Developing software applications", "Designing and building robotic systems", "Developing new materials", "Structural analysis of buildings"}, 1))
                questions.Add(New Question("What is the purpose of a geodetic engineer?", {"Designing communication systems", "Measuring and mapping the Earth's surface", "Designing computer algorithms", "Industrial process optimization"}, 1))
                questions.Add(New Question("In mechanical engineering, what does the term 'kinematics' refer to?", {"Study of fluids in motion", "Study of motion without considering the forces involved", "Analysis of heat transfer", "Structural materials testing"}, 1))
                questions.Add(New Question("What is the main focus of mechatronics engineering?", {"Structural design of buildings", "Integration of mechanical engineering with electronics and computer science", "Developing chemical processes", "Aerospace propulsion systems"}, 1))
                questions.Add(New Question("In chemical engineering, what is the purpose of a distillation column?", {"Extracting metals from ores", "Separating and purifying liquid mixtures", "Developing new chemical compounds", "Designing electrical circuits"}, 1))
                questions.Add(New Question("What is the term for the study of the interaction between humans and machines in industrial design?", {"Ergonomics", "Biomechanics", "Human-machine interface", "Cognitive engineering"}, 0))
                questions.Add(New Question("What is the purpose of a materials engineer?", {"Analyzing environmental impact", "Developing and testing new materials", "Designing computer networks", "Structural analysis of buildings"}, 1))
                questions.Add(New Question("In aerospace engineering, what is the purpose of a wind tunnel?", {"Testing aircraft engines", "Simulating aerodynamic conditions to study the behavior of aircraft", "Analyzing structural materials", "Developing avionic systems"}, 1))
                questions.Add(New Question("What does the term 'nanotechnology' involve in engineering?", {"Designing and manufacturing at the molecular and atomic scale", "Building large-scale structures", "Developing new chemical processes", "Environmental impact assessment"}, 0))
                questions.Add(New Question("What is the main focus of nuclear engineering?", {"Structural design of buildings", "Designing and operating nuclear systems", "Developing computer algorithms", "Aerospace propulsion systems"}, 1))
                questions.Add(New Question("In telecommunications engineering, what does the term 'bandwidth' refer to?", {"The range of frequencies available for signal transmission", "The thickness of a cable", "The distance between communication towers", "The speed of data transfer"}, 0))
                questions.Add(New Question("What is the purpose of a civil engineering surveyor?", {"Designing and analyzing structures", "Conducting land surveys and providing data for construction projects", "Designing computer algorithms", "Materials testing"}, 1))
                questions.Add(New Question("In electrical engineering, what is the primary function of a transformer?", {"Generating electricity", "Changing voltage levels in electrical circuits", "Converting mechanical energy into electrical energy", "Developing computer hardware"}, 1))
                questions.Add(New Question("What is the term for the study of fluid flow and its application in engineering?", {"Thermodynamics", "Aerodynamics", "Fluid mechanics", "Kinematics"}, 2))
                questions.Add(New Question("What is the primary focus of fire protection engineering?", {"Designing fire alarms", "Preventing and mitigating the impact of fires on structures and people", "Analyzing environmental impact", "Developing firefighting equipment"}, 1))
                questions.Add(New Question("In computer engineering, what does the term 'RAM' stand for?", {"Random Access Memory", "Read-Only Memory", "Real-time Analysis Module", "Remote Access Mechanism"}, 0))

            Case "Hm"

                questions.Add(New Question("What does the term 'yield management' refer to in the hospitality industry?", {"Managing agricultural resources", "Maximizing revenue through strategic pricing", "Maintaining hotel landscaping", "Balancing check-in and check-out times"}, 1))
                questions.Add(New Question("In hospitality, what does the acronym 'OTA' stand for?", {"Office of Tourism and Accommodation", "Online Travel Agency", "Order of Tourism Associates", "Operational Training Assessment"}, 1))
                questions.Add(New Question("What is the primary focus of a concierge in a hotel?", {"Housekeeping services", "Guest services and recommendations", "Financial management", "Event planning"}, 1))
                questions.Add(New Question("What does the term 'RevPAR' stand for in hotel management?", {"Revenue Per Available Room", "Reservation and Payment", "Room Variation and Pricing", "Restaurant and Bar"}, 0))
                questions.Add(New Question("Which department is responsible for overseeing food and beverage operations in a hotel?", {"Housekeeping", "Front office", "Food and Beverage", "Maintenance"}, 2))
                questions.Add(New Question("What is the purpose of a SWOT analysis in hospitality management?", {"Social Welfare and Occupational Training", "Strategic Workforce Optimization and Training", "Strengths, Weaknesses, Opportunities, Threats", "Service Workflow and Operational Tactics"}, 2))
                questions.Add(New Question("What is the term for a hotel room rate that includes meals in addition to accommodations?", {"Room-only rate", "Bed and Breakfast rate", "Full board rate", "Half-board rate"}, 1))
                questions.Add(New Question("In the context of hospitality, what does 'CRM' stand for?", {"Customer Relationship Management", "Central Reservation Management", "Catering and Room Management", "Concierge and Reception Management"}, 0))
                questions.Add(New Question("What is the primary role of a revenue manager in a hotel?", {"Handling guest complaints", "Maximizing revenue and profits", "Managing housekeeping staff", "Planning marketing campaigns"}, 1))
                questions.Add(New Question("What is the purpose of a guest folio in hotel accounting?", {"Employee schedule", "Guest room reservation", "Guest account statement", "Food and beverage inventory"}, 2))
                questions.Add(New Question("What does the term 'Banquet Event Order' (BEO) refer to in hospitality management?", {"Booking executive offices", "Managing beverage orders", "Detailed instructions for an event or function", "Budgeting for events"}, 2))
                questions.Add(New Question("In the context of hospitality, what does 'A la carte' mean?", {"Buffet-style dining", "Pre-set menu", "Individual item pricing", "All-inclusive package"}, 2))
                questions.Add(New Question("What is the primary goal of a hotel loyalty program?", {"Increasing room rates", "Retaining and rewarding repeat guests", "Expanding the hotel's physical space", "Promoting local tourism"}, 1))
                questions.Add(New Question("What does the term 'turn-down service' involve in hotel management?", {"Turning off lights in unoccupied rooms", "Preparing rooms for new guests", "Evening room preparation, including bed turndown", "Closing down the hotel for the night"}, 2))
                questions.Add(New Question("What is the purpose of a PMS in hospitality management?", {"Profitable Marketing Strategies", "Property Maintenance Services", "Property Management System", "Public Media and Sponsorships"}, 2))
                questions.Add(New Question("In the hotel industry, what does 'occupancy rate' measure?", {"Staffing levels", "Guest satisfaction", "Percentage of rooms occupied", "Average room rate"}, 2))
                questions.Add(New Question("What is the primary focus of a sommelier in the hospitality industry?", {"Housekeeping services", "Beverage selection and service, particularly wine", "Event planning", "Guest check-in and check-out"}, 1))
                questions.Add(New Question("What does the term 'green hotel' refer to in the hospitality industry?", {"Hotels painted in green colors", "Environmentally sustainable and eco-friendly hotels", "Hotels with extensive gardens", "Hotels with a focus on green technologies"}, 1))
                questions.Add(New Question("What is the purpose of a feasibility study in hotel development?", {"Evaluating the feasibility of a new hotel project", "Conducting employee training", "Analyzing guest reviews", "Assessing room rates"}, 0))
                questions.Add(New Question("What is the primary responsibility of a front office manager in a hotel?", {"Managing housekeeping staff", "Overseeing reservations and guest services", "Coordinating events and banquets", "Handling food and beverage operations"}, 1))
                questions.Add(New Question("What is the term for the practice of overbooking hotel rooms to compensate for potential cancellations?", {"Double-booking", "Reservation guarantee", "Overstay management", "Overbooking"}, 3))
                questions.Add(New Question("What is the purpose of a fire evacuation plan in a hotel?", {"Room assignment during emergencies", "Ensuring guest safety and orderly evacuation", "Managing kitchen fires", "Emergency medical response"}, 1))
                questions.Add(New Question("In hotel management, what does 'GOPPAR' stand for?", {"Gross Operating Profit Per Available Room", "Guest Occupancy Percentage Performance and Revenue", "General Operations and Profit Performance Assessment", "Group Oriented Profit and Pricing"}, 0))
                questions.Add(New Question("What is the term for a hotel's published maximum rate for a room?", {"Rack rate", "Base rate", "Corporate rate", "Discounted rate"}, 0))
                questions.Add(New Question("What does the term 'Bleisure' mean in the context of hospitality?", {"A cleaning service for bed linens", "A blend of business and leisure travel", "A type of room service", "A leisure-only reservation"}, 1))
                questions.Add(New Question("What is the primary role of a housekeeping manager in a hotel?", {"Managing front office operations", "Overseeing food and beverage services", "Ensuring cleanliness and maintenance of rooms", "Handling guest complaints"}, 2))
                questions.Add(New Question("What is the purpose of a banquet captain in event management?", {"Managing catering finances", "Overseeing banquet staff and operations", "Coordinating housekeeping services", "Planning marketing events"}, 1))
                questions.Add(New Question("What is the purpose of a GDS in the hospitality industry?", {"Guest Data System", "Group Discount Service", "Global Distribution System", "Guest Dining Service"}, 2))
                questions.Add(New Question("What is the term for the practice of serving food to guests at their tables rather than allowing them to serve themselves?", {"Buffet service", "À la carte service", "Table service", "Room service"}, 2))
                questions.Add(New Question("What is the purpose of a banquet event sheet (BES) in event planning?", {"Guest list for a banquet", "Detailed instructions and schedule for an event", "Budget for a banquet", "Food and beverage inventory for banquets"}, 1))
                questions.Add(New Question("What is the purpose of a fire drill in a hotel?", {"Testing alarm systems", "Practicing emergency evacuation procedures", "Conducting staff training", "Evaluating fire prevention measures"}, 1))
                questions.Add(New Question("What does the term 'Catering Sales Manager' typically involve in the hospitality industry?", {"Managing room reservations", "Overseeing catering sales and events", "Managing the hotel's financial accounts", "Coordinating housekeeping services"}, 1))
                questions.Add(New Question("What is the term for the practice of offering discounted room rates for guests who book in advance?", {"Last-minute deals", "Early booking discount", "Extended stay promotion", "Flash sale"}, 1))
                questions.Add(New Question("What is the primary focus of a restaurant manager in a hotel?", {"Housekeeping services", "Guest services", "Food and beverage operations", "Front office operations"}, 2))
                questions.Add(New Question("What does the term 'occupancy tax' refer to in the hospitality industry?", {"Tax on employee wages", "Tax on room revenue collected from guests", "Tax on food and beverage sales", "Tax on hotel property value"}, 1))

            Case "IT"

                questions.Add(New Question("What does 'IDE' stand for in programming?", {"Integrated Design Environment", "Integrated Development Environment", "Internet Development Engine", "Intelligent Debugging Environment"}, 1))
                questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "Machine Code"}, 2))
                questions.Add(New Question("In programming, what is the purpose of a 'variable'?", {"It is used to create loops.", "It represents a value that can change", "It is a type of comment.", "It is used for printing text."}, 1))
                questions.Add(New Question("Which programming paradigm focuses on defining data structures and the methods that operate on them?", {"Object-Oriented Programming", "Functional Programming", "Procedural Programming", "Imperative Programming"}, 0))
                questions.Add(New Question("What is the primary function of a 'for loop' in programming?", {"To define classes", "To encapsulate data", "To iterate a specific number of times", "To perform calculations"}, 2))
                questions.Add(New Question("What does 'API' stand for in programming?", {"Automated Programming Interface", "Application Programming Interface", "Advanced Programming Instruction", "Automated Program Integration"}, 1))
                questions.Add(New Question("In programming, what is 'debugging'?", {"Adding new features to a program", "The process of identifying and fixing errors in code", "Documenting code", "Optimizing code for speed"}, 1))
                questions.Add(New Question("Which programming language is often used for web development on the client side?", {"C++", "Python", "JavaScript", "SQL"}, 2))
                questions.Add(New Question("What does 'OOP' stand for in programming?", {"Object-Oriented Programming", "Object-Oriented Protocol", "Open-Source Project", "Object-Oriented Procedure"}, 0))
                questions.Add(New Question("What is a 'Boolean' in programming?", {"A data type that represents true or false values", "A type of loop", "A specific error message", "A way to hide code from others"}, 0))
                questions.Add(New Question("What is the purpose of a 'while loop' in programming?", {"To define classes", "To encapsulate data", "To perform a specific action repeatedly while a condition is true", "To display messages to the user"}, 2))
                questions.Add(New Question("What is 'algorithm' in programming?", {"A mathematical equation", "A step-by-step procedure for solving a specific problem or performing a task", "A type of programming language", "A programming error message"}, 1))
                questions.Add(New Question("What is the purpose of 'conditional statements' in programming?", {"They are used for adding comments to code", "They allow you to make decisions in your code based on certain conditions", "They represent different data types", "They help with code formatting"}, 1))
                questions.Add(New Question("What is the purpose of 'comments' in programming code?", {"To execute code", "To prevent code from running", "To provide explanations or notes within the code for documentation and readability", "To create user interfaces"}, 2))
                questions.Add(New Question("In programming, what is a 'stack' and a 'queue'?", {"Data types", "Data structures used for storing and accessing elements in a specific order", "Functions for drawing graphics", "Networking protocols"}, 1))
                questions.Add(New Question("Who is considered the world's first computer programmer?", {"Charles Babbage", "Alan Turing", "Ada Lovelace", "Grace Hopper"}, 2))
                questions.Add(New Question("What machine was Ada Lovelace working on with Charles Babbage when she wrote the first computer program?", {"ENIAC", "UNIVAC", "Analytical Engine", "Difference Engine"}, 2))
                questions.Add(New Question("In which year did Ada Lovelace write her notes and programs for the Analytical Engine?", {"1812", "1837", "1843", "1865"}, 2))
                questions.Add(New Question("Who designed the first mechanical computer, known as the Analytical Engine?", {"Alan Turing", "John von Neumann", "Charles Babbage", "Ada Lovelace"}, 2))
                questions.Add(New Question("When was the first functioning model of the Analytical Engine built?", {"It was never built during Babbage's lifetime", "1940s", "1960s", "2002"}, 0))
                questions.Add(New Question("Who was Charles Babbage?", {"A famous painter", "A renowned mathematician and inventor", "A famous actor", "A medieval historian"}, 1))
                questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "All of the above"}, 2))
                questions.Add(New Question("What is a data structure?", {"A way to structure code in a program", "A way to structure data for storage and efficient access", "A type of programming language", "A data visualization tool"}, 1))
                questions.Add(New Question("Which of the following is not a commonly used data structure in programming?", {"Arrays", "Trees", "Algorithms", "Stacks"}, 2))
                questions.Add(New Question("Who developed Visual Basic?", {"Microsoft", "IBM", "Apple", "Oracle"}, 0))
                questions.Add(New Question("What is Visual Basic?", {"A web browser", "A visual design tool for creating user interfaces", "A programming language and integrated development environment (IDE)", "A type of computer monitor"}, 2))
                questions.Add(New Question("Who developed JavaScript?", {"Microsoft", "Sun Microsystems", "Netscape", "IBM"}, 2))
                questions.Add(New Question("What is JavaScript?", {"A type of coffee", "A markup language", "A high-level, interpreted programming language for web development", "A document format"}, 2))
                questions.Add(New Question("Who originally developed Java?", {"Apple", "IBM", "Microsoft", "Sun Microsystems"}, 3))
                questions.Add(New Question("What does 'JRE' stand for in Java?", {"Java Runtime Engine", "Java Runtime Environment", "Java Running Emulator", "Java Resource Editor"}, 1))

            Case "Marketing"

                questions.Add(New Question("What is the primary goal of marketing?", {"Maximizing profits", "Building brand awareness and satisfying customer needs", "Cost reduction", "Employee satisfaction"}, 1))
                questions.Add(New Question("What does SWOT stand for in marketing analysis?", {"Special Ways of Organizing Trends", "Strengths, Weaknesses, Opportunities, Threats", "Sales, Wins, Objectives, Targets", "Strategic Workflow for Organizational Tactics"}, 1))
                questions.Add(New Question("What is the term for the set of controllable marketing variables that a company combines to satisfy a target group?", {"Marketing mix", "Promotion strategy", "Brand positioning", "Target marketing"}, 0))
                questions.Add(New Question("In marketing, what does ROI stand for?", {"Return on Investment", "Rate of Interest", "Results of Incentive", "Revenue over Impressions"}, 0))
                questions.Add(New Question("What is the purpose of market segmentation?", {"Combining diverse markets into one", "Dividing a market into distinct groups with similar needs", "Increasing product prices", "Reducing competition"}, 1))
                questions.Add(New Question("What is the term for the unique value that a product or service provides to its customers?", {"Price point", "Unique Selling Proposition (USP)", "Market share", "Cost per click"}, 1))
                questions.Add(New Question("What does CTA stand for in marketing?", {"Call to Action", "Customer Testimonial and Approval", "Cost per Acquisition", "Consumer Target Analysis"}, 0))
                questions.Add(New Question("In digital marketing, what does SEO stand for?", {"Social Engagement Optimization", "Search Engine Optimization", "Strategic Email Outreach", "Sales Enablement Operations"}, 1))
                questions.Add(New Question("What is the term for the process of turning potential customers into actual customers?", {"Lead generation", "Conversion", "Customer retention", "Market penetration"}, 1))
                questions.Add(New Question("What is the 4 Ps in the marketing mix?", {"Price, Product, Promotion, Place", "Profit, People, Planning, Packaging", "Performance, Positioning, Publicity, Partnerships", "Process, Policies, Planning, Productivity"}, 0))
                questions.Add(New Question("What does the term 'brand equity' refer to in marketing?", {"The financial value of a brand", "The perceived value and strength of a brand", "The cost of brand development", "The variety of products under a brand"}, 1))
                questions.Add(New Question("What is the primary purpose of a marketing plan?", {"Tracking competitors", "Outlining marketing goals and strategies", "Managing customer complaints", "Increasing production efficiency"}, 1))
                questions.Add(New Question("In marketing, what is the AIDA model used for?", {"Assessing Individual Demands and Attributes", "Attention, Interest, Desire, Action", "Analyzing Industry Data and Analytics", "Acquiring International Distributor Agreements"}, 1))
                questions.Add(New Question("What is the term for a pricing strategy where a product is initially offered at a lower price to gain market share?", {"Penetration pricing", "Premium pricing", "Discount pricing", "Cost-plus pricing"}, 0))
                questions.Add(New Question("What is the main goal of content marketing?", {"Generating leads", "Providing valuable and relevant content to attract and retain a target audience", "Maximizing profits", "Improving product quality"}, 1))
                questions.Add(New Question("What does CRM stand for in marketing?", {"Customer Relationship Management", "Cost Reduction Metrics", "Creative Resource Management", "Competitive Revenue Models"}, 0))
                questions.Add(New Question("What is the term for the process of gathering, storing, and analyzing customer data?", {"Data mining", "Customer profiling", "Customer relationship management (CRM)", "Target audience segmentation"}, 2))
                questions.Add(New Question("What does the term 'guerrilla marketing' refer to?", {"Unconventional and low-budget marketing tactics to generate maximum impact", "Military-inspired advertising", "Large-scale promotional events", "Social media marketing"}, 0))
                questions.Add(New Question("What is the purpose of a call-to-action (CTA) in marketing materials?", {"Providing contact information", "Prompting the audience to take a specific action", "Displaying product features", "Offering discounts and promotions"}, 1))
                questions.Add(New Question("What is the term for the process of systematically tracking, evaluating, and adjusting marketing strategies over time?", {"Marketing audit", "Marketing evaluation", "Marketing analytics", "Marketing optimization"}, 2))
                questions.Add(New Question("What is the primary focus of influencer marketing?", {"Traditional advertising channels", "Leveraging influencers' credibility to promote products", "Maximizing online visibility", "Analyzing customer demographics"}, 1))
                questions.Add(New Question("What does the acronym USP stand for in marketing?", {"Universal Sales Promotion", "Unique Selling Proposition", "Ultimate Sales Performance", "Unbeatable Sales Prices"}, 1))
                questions.Add(New Question("In marketing, what is the term for the visual representation of data and information?", {"Infographic", "Logo", "Tagline", "Billboard"}, 0))
                questions.Add(New Question("What is the purpose of A/B testing in marketing?", {"Assessing advertising budgets", "Comparing two versions of a marketing element to determine which performs better", "Analyzing customer testimonials", "Allocating resources for marketing campaigns"}, 1))
                questions.Add(New Question("What is the term for the strategy of adjusting a product's features, design, or pricing to better meet the needs of a particular market segment?", {"Diversification", "Product adaptation", "Market penetration", "Cost leadership"}, 1))
                questions.Add(New Question("What is the primary goal of social media marketing?", {"Maximizing advertising costs", "Building brand awareness and engaging with audiences on social platforms", "Analyzing competitor strategies", "Reducing customer complaints"}, 1))
                questions.Add(New Question("What is the term for the practice of creating and distributing valuable, relevant content to attract and engage a target audience?", {"Social media marketing", "Content marketing", "Email marketing", "Influencer marketing"}, 1))
                questions.Add(New Question("What is the term for a marketing strategy that aims to create a unique and consistent brand image across all platforms and channels?", {"Brand differentiation", "Integrated marketing communication (IMC)", "Viral marketing", "Comparative advertising"}, 1))
                questions.Add(New Question("What is the purpose of a landing page in online marketing?", {"Displaying product prices", "Capturing visitor information and encouraging a specific action", "Providing company contact information", "Showcasing customer testimonials"}, 1))
                questions.Add(New Question("What does the term 'market share' represent in marketing?", {"The total sales revenue of a company", "The percentage of total sales in a market that a company owns", "The number of products sold in a given period", "The average consumer spending on a product"}, 1))
                questions.Add(New Question("What is the term for the practice of marketing products or services based on consumers' interests and behaviors?", {"Niche marketing", "Behavioral marketing", "Relationship marketing", "Cause-related marketing"}, 1))
                questions.Add(New Question("In marketing, what is the term for the process of setting a price for a product based on perceived value?", {"Cost-based pricing", "Value-based pricing", "Dynamic pricing", "Psychological pricing"}, 1))
                questions.Add(New Question("What does the term 'call-out culture' refer to in social media marketing?", {"Promoting customer calls to action", "A social trend of publicly criticizing brands or individuals", "Encouraging positive customer reviews", "Providing customer service through phone calls"}, 1))
                questions.Add(New Question("What is the term for the strategy of pricing a product below its market value to gain rapid market share?", {"Penetration pricing", "Price skimming", "Loss leader pricing", "Discount pricing"}, 2))
                questions.Add(New Question("What does the term 'brand positioning' involve in marketing?", {"Defining the unique space a brand occupies in the minds of consumers", "Setting the price of a product", "Launching a new brand", "Evaluating brand performance against competitors"}, 0))

            Case "PolSci"

                questions.Add(New Question("What is the primary focus of political science?", {"Psychological analysis of political leaders", "Study of government systems, political behavior, and power relations", "Economic policies of nations", "Historical events"}, 1))
                questions.Add(New Question("In political science, what does the term 'ideology' refer to?", {"Political parties", "Systematic body of ideas about human life and culture", "International relations", "Political campaigns"}, 1))
                questions.Add(New Question("What is the term for a government system where power is held by the people, either directly or through elected representatives?", {"Autocracy", "Oligarchy", "Democracy", "Monarchy"}, 2))
                questions.Add(New Question("In political science, what is the purpose of comparative politics?", {"Analyzing political ideologies", "Studying and comparing political systems, structures, and behaviors across different countries", "Examining historical events", "Investigating political corruption"}, 1))
                questions.Add(New Question("What does the term 'separation of powers' mean in political science?", {"Division of government responsibilities among different branches", "Delegation of power to a single ruler", "Collaboration of political parties", "Equal distribution of resources"}, 0))
                questions.Add(New Question("What is the term for a form of government in which a single ruler holds all political power?", {"Oligarchy", "Autocracy", "Democracy", "Plutocracy"}, 1))
                questions.Add(New Question("In political science, what does the term 'political ideology' encompass?", {"Political party platforms", "Systematic beliefs about politics, society, and the role of government", "Electoral systems", "Political campaigns"}, 1))
                questions.Add(New Question("What is the primary focus of international relations in political science?", {"Domestic politics", "Interactions between countries, including diplomacy and conflict", "Political theories", "Comparative analysis of political systems"}, 1))
                questions.Add(New Question("In political science, what is the term for a system where power is concentrated in the hands of a small, privileged group?", {"Autocracy", "Plutocracy", "Democracy", "Oligarchy"}, 1))
                questions.Add(New Question("What does the term 'civil rights' refer to in political science?", {"Rights related to criminal proceedings", "Legal and political rights that protect individuals from discrimination", "Rights of government officials", "Rights of military personnel"}, 1))
                questions.Add(New Question("What is the purpose of political economy in political science?", {"Studying the economic policies of political parties", "Examining the relationship between politics and economics", "Analyzing political ideologies", "Investigating political corruption"}, 1))
                questions.Add(New Question("What is the term for a system of government where power is inherited within a family?", {"Democracy", "Monarchy", "Oligarchy", "Theocracy"}, 1))
                questions.Add(New Question("In political science, what is the term for a society where power is concentrated in the hands of a religious authority?", {"Theocracy", "Secular state", "Plutocracy", "Autocracy"}, 0))
                questions.Add(New Question("What does the term 'lobbying' involve in political science?", {"Political activism", "Advocacy to influence government decisions", "Party politics", "Political campaigns"}, 1))
                questions.Add(New Question("What is the term for a political system where citizens participate directly in decision-making?", {"Representative democracy", "Direct democracy", "Oligarchy", "Autocracy"}, 1))
                questions.Add(New Question("What is the purpose of political theory in political science?", {"Analyzing historical events", "Examining the philosophical foundations of political systems and behavior", "Studying electoral systems", "Investigating political corruption"}, 1))
                questions.Add(New Question("In political science, what does the term 'federalism' mean?", {"Centralization of power in a single government entity", "Distribution of power between a central government and subnational entities", "Autocratic rule", "Global governance"}, 1))
                questions.Add(New Question("What is the term for the study of government structures and functions?", {"Political theory", "Political sociology", "Political institutions", "Political economy"}, 2))
                questions.Add(New Question("In political science, what does the term 'public policy' refer to?", {"International relations", "Decisions and actions taken by governments to address societal issues", "Political ideologies", "Political campaigns"}, 1))
                questions.Add(New Question("What does the term 'globalization' involve in political science?", {"The study of global political events", "The interconnectedness of economies, cultures, and politics on a global scale", "Political theories", "The influence of media on political discourse"}, 1))
                questions.Add(New Question("In political science, what is the term for a system where power is vested in religious leaders?", {"Oligarchy", "Theocracy", "Autocracy", "Plutocracy"}, 1))
                questions.Add(New Question("What is the term for a political system where power is concentrated in the hands of a single political party?", {"Democracy", "Autocracy", "One-party system", "Oligarchy"}, 2))
                questions.Add(New Question("In political science, what does the term 'political culture' involve?", {"The study of international relations", "Shared beliefs, values, and norms about politics within a society", "Political ideologies", "The role of the media in politics"}, 1))
                questions.Add(New Question("What is the term for a set of fundamental principles that govern a society's legal system?", {"Political economy", "Constitutional law", "International law", "Administrative law"}, 1))
                questions.Add(New Question("In political science, what is the term for a formal agreement between two or more countries?", {"Treaty", "Alliance", "Accord", "Compact"}, 0))
                questions.Add(New Question("What is the term for the exercise of power and influence over governmental decision-making?", {"Authority", "Governance", "Politics", "Administration"}, 2))
                questions.Add(New Question("In political science, what does the term 'soft power' mean?", {"Military strength", "Influence through attraction and persuasion", "Coercive tactics", "Economic dominance"}, 1))
                questions.Add(New Question("What is the purpose of political sociology in political science?", {"Analyzing international relations", "Examining the relationship between society and politics", "Studying political ideologies", "Investigating political corruption"}, 1))
                questions.Add(New Question("In political science, what does the term 'democratic deficit' refer to?", {"Lack of democratic institutions", "Insufficient representation or participation in the democratic process", "Excessive democratic practices", "Weakness in democratic leadership"}, 1))
                questions.Add(New Question("What is the term for the principle of non-interference in the internal affairs of other countries?", {"Sovereignty", "Isolationism", "Non-intervention", "Neutrality"}, 2))
                questions.Add(New Question("In political science, what does the term 'political party' refer to?", {"Organized groups that seek to influence government policies and gain political power", "Government agencies", "Interest groups", "Lobbying organizations"}, 0))
                questions.Add(New Question("What is the term for a system of government where power is shared between a central government and regional entities?", {"Unitary system", "Federal system", "Confederal system", "Parliamentary system"}, 1))
                questions.Add(New Question("In political science, what does the term 'citizenship' involve?", {"Membership and participation in a political community with rights and duties", "Immigration policies", "Political ideologies", "Voter registration"}, 0))
                questions.Add(New Question("What is the term for the practice of giving government jobs to individuals based on their political loyalty rather than merit?", {"Civil service reform", "Nepotism", "Spoils system", "Meritocracy"}, 2))
                questions.Add(New Question("In political science, what does the term 'human rights' refer to?", {"Rights granted by governments to individuals", "Universal rights inherent to all human beings, regardless of nationality, ethnicity, or religion", "Civil rights", "Legal rights granted by international agreements"}, 1))

            Case "Tourism"

                questions.Add(New Question("What is ecotourism?", {"Extreme sports tourism", "Tourism focused on preserving natural environments and wildlife", "Luxury resort tourism", "Urban tourism"}, 1))
                questions.Add(New Question("In the context of tourism, what does the term 'staycation' mean?", {"Extended vacation", "Traveling to a foreign country", "Taking a vacation close to home", "Staying in a specific type of accommodation"}, 2))
                questions.Add(New Question("What is the primary goal of sustainable tourism?", {"Maximizing profit for tourism businesses", "Minimizing the environmental impact and promoting social responsibility", "Attracting large crowds to tourist destinations", "Offering exclusive, high-cost experiences"}, 1))
                questions.Add(New Question("What does the term 'cultural appropriation' mean in the context of tourism?", {"Embracing and respecting local cultures", "Borrowing elements of a culture without understanding or respecting its significance", "Supporting local artisans", "Promoting cultural exchange"}, 1))
                questions.Add(New Question("What is the purpose of a tourist information center?", {"Selling souvenirs", "Providing information and assistance to tourists", "Booking flights for tourists", "Offering guided tours"}, 1))
                questions.Add(New Question("What is the term for the practice of traveling to experience and observe wild animals in their natural habitats?", {"Zoological tourism", "Wildlife tourism", "Petting zoo tourism", "Safari tourism"}, 1))
                questions.Add(New Question("What is a UNESCO World Heritage Site in the context of tourism?", {"A popular tourist destination", "A site recognized for its cultural, natural, or mixed significance", "A luxury resort", "A site restricted for locals only"}, 1))
                questions.Add(New Question("What is the main purpose of a tourist visa?", {"Allowing tourists to work in the destination country", "Granting entry for a specified period to visit and travel in the destination country", "Providing discounts on tourist attractions", "Facilitating cultural exchange programs"}, 1))
                questions.Add(New Question("What does the term 'over-tourism' refer to in the tourism industry?", {"A surge in tourism revenue", "Excessive tourism that negatively impacts the environment and local communities", "Promoting tourism through social media", "Government incentives for tourism development"}, 1))
                questions.Add(New Question("In aviation, what does the term 'hub airport' mean?", {"An airport with a single terminal", "An airport that serves as a central connecting point for flights", "An airport exclusively for private jets", "An airport with limited international flights"}, 1))
                questions.Add(New Question("What is the purpose of the International Air Transport Association (IATA)?", {"Setting global standards for the airline industry", "Promoting tourism destinations", "Providing travel insurance", "Managing hotel reservations"}, 0))
                questions.Add(New Question("What does the term 'tourism infrastructure' encompass?", {"Tourist attractions only", "Physical and organizational structures that support tourism", "Tourist visas and documentation", "Cultural events and festivals"}, 1))
                questions.Add(New Question("What is the primary focus of adventure tourism?", {"Luxury accommodations", "Extreme and outdoor activities", "Historical and cultural experiences", "Culinary tourism"}, 1))
                questions.Add(New Question("What is the purpose of a tourist board or tourism bureau?", {"Promoting local businesses", "Attracting and promoting tourism in a specific destination", "Providing accommodation for tourists", "Offering guided tours for tourists"}, 1))
                questions.Add(New Question("What is the term for the process of a cruise ship docking at a port to allow passengers to go ashore?", {"Docking", "Porting", "Shore excursion", "Embarkation"}, 2))
                questions.Add(New Question("What does the term 'all-inclusive resort' mean in the context of tourism?", {"A resort that includes all possible amenities and services in one price", "A resort with limited facilities", "A resort exclusively for adults", "A resort without meal options"}, 0))
                questions.Add(New Question("What is the purpose of the World Travel & Tourism Council (WTTC)?", {"Promoting travel destinations", "Advocating for the interests of the global travel and tourism industry", "Providing travel insurance", "Organizing international tourist events"}, 1))
                questions.Add(New Question("What is the primary focus of medical tourism?", {"Visiting healthcare facilities for educational purposes", "Traveling for medical treatment and healthcare services", "Exploring destinations with natural healing properties", "Promoting healthy lifestyles through tourism"}, 1))
                questions.Add(New Question("What does the term 'jet lag' refer to in the context of travel?", {"Fear of flying", "A temporary sleep disorder caused by crossing multiple time zones", "Flight delays due to weather conditions", "Frequent travel by private jet"}, 1))
                questions.Add(New Question("What is the purpose of the Schengen Area in Europe in relation to tourism?", {"Facilitating visa-free travel between participating countries", "Promoting exclusive tourist experiences", "Standardizing tourism regulations", "Establishing a currency exchange network"}, 0))
                questions.Add(New Question("In the context of tourism, what does the term 'destination marketing' involve?", {"Marketing products for tourists", "Promoting and advertising a specific location as a tourist destination", "Marketing travel agencies", "Marketing services for local residents"}, 1))
                questions.Add(New Question("What is the term for the practice of travelers staying in private homes, typically booked through online platforms?", {"Hotel accommodation", "Hostel lodging", "Vacation rental or homestay", "Bed and breakfast"}, 2))
                questions.Add(New Question("What does the term 'tourist season' refer to in tourism management?", {"The peak time for tourists to visit a destination", "The off-peak period with fewer tourists", "The duration of a tourist's stay", "The time for local residents to travel"}, 0))
                questions.Add(New Question("What is the primary goal of a tourist information app?", {"Booking flights", "Providing real-time information and assistance to tourists", "Offering virtual tours", "Reviewing hotels and restaurants"}, 1))
                questions.Add(New Question("What is the term for the practice of promoting and preserving the identity and heritage of a local community in tourism?", {"Cultural assimilation", "Cultural preservation", "Cultural appropriation", "Cultural diffusion"}, 1))
                questions.Add(New Question("What does the term 'bucket list' mean in the context of travel?", {"A list of items to bring on a trip", "A list of places or experiences a person wants to visit or accomplish in their lifetime", "A list of travel restrictions", "A list of prohibited items in luggage"}, 1))
                questions.Add(New Question("What is the purpose of a travel insurance policy?", {"Providing discounts on travel services", "Ensuring financial protection for travelers against unforeseen events", "Facilitating visa applications", "Offering exclusive travel experiences"}, 1))
                questions.Add(New Question("What is the term for a traveler who visits a destination with the intention of experiencing its local cuisine?", {"Cultural enthusiast", "Culinary tourist or foodie", "Adventure seeker", "Eco-conscious traveler"}, 1))
                questions.Add(New Question("What does the term 'cruise ship tender' refer to?", {"A type of cruise ship", "A small boat used to transport passengers to and from the ship when it cannot dock at a port", "A special dining area on a cruise ship", "A cruise ship with limited amenities"}, 1))
                questions.Add(New Question("What is the purpose of the International Civil Aviation Organization (ICAO)?", {"Promoting luxury air travel", "Establishing international standards for aviation safety, security, and environmental protection", "Advocating for budget air travel", "Regulating domestic flights"}, 1))
                questions.Add(New Question("In tourism, what does the term 'tour operator' mean?", {"A travel agency specializing in adventure tours", "A company that organizes and sells package tours", "A guide for individual tourists", "A transportation company for tourists"}, 1))
                questions.Add(New Question("What is the term for a form of tourism that involves volunteering for community service projects while traveling?", {"Adventure tourism", "Volunteer tourism or voluntourism", "Cultural tourism", "Educational tourism"}, 1))
                questions.Add(New Question("What does the term 'airbnb effect' refer to in the tourism industry?", {"The impact of Airbnb on traditional hotel businesses", "The increase in domestic tourism", "The popularity of Airbnb experiences", "The decrease in travel agency bookings"}, 2))
                questions.Add(New Question("What is the primary focus of event tourism?", {"Sightseeing and cultural experiences", "Attending and organizing events and festivals", "Adventure activities", "Luxury travel experiences"}, 1))
                questions.Add(New Question("In the context of tourism, what does the term 'tourism multiplier effect' refer to?", {"The economic impact of tourism that ripples through a local economy", "The increase in the number of tourists", "The impact of tourism on the environment", "The promotion of local tourism through social media"}, 0))

            Case "Random"
                MsgBox("RAndom")



        End Select

        'If My.Settings.categoryStr = "IT" Then
        '    questions.Add(New Question("What does 'IDE' stand for in programming?", {"Integrated Design Environment", "Integrated Development Environment", "Internet Development Engine", "Intelligent Debugging Environment"}, 1))
        '    questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "Machine Code"}, 2))
        '    questions.Add(New Question("In programming, what is the purpose of a 'variable'?", {"It is used to create loops.", "It represents a value that can change", "It is a type of comment.", "It is used for printing text."}, 1))
        '    questions.Add(New Question("Which programming paradigm focuses on defining data structures and the methods that operate on them?", {"Object-Oriented Programming", "Functional Programming", "Procedural Programming", "Imperative Programming"}, 0))
        '    questions.Add(New Question("What is the primary function of a 'for loop' in programming?", {"To define classes", "To encapsulate data", "To iterate a specific number of times", "To perform calculations"}, 2))
        '    questions.Add(New Question("What does 'API' stand for in programming?", {"Automated Programming Interface", "Application Programming Interface", "Advanced Programming Instruction", "Automated Program Integration"}, 1))
        '    questions.Add(New Question("In programming, what is 'debugging'?", {"Adding new features to a program", "The process of identifying and fixing errors in code", "Documenting code", "Optimizing code for speed"}, 1))
        '    questions.Add(New Question("Which programming language is often used for web development on the client side?", {"C++", "Python", "JavaScript", "SQL"}, 2))
        '    questions.Add(New Question("What does 'OOP' stand for in programming?", {"Object-Oriented Programming", "Object-Oriented Protocol", "Open-Source Project", "Object-Oriented Procedure"}, 0))
        '    questions.Add(New Question("What is a 'Boolean' in programming?", {"A data type that represents true or false values", "A type of loop", "A specific error message", "A way to hide code from others"}, 0))
        '    questions.Add(New Question("What is the purpose of a 'while loop' in programming?", {"To define classes", "To encapsulate data", "To perform a specific action repeatedly while a condition is true", "To display messages to the user"}, 2))
        '    questions.Add(New Question("What is 'algorithm' in programming?", {"A mathematical equation", "A step-by-step procedure for solving a specific problem or performing a task", "A type of programming language", "A programming error message"}, 1))
        '    questions.Add(New Question("What is the purpose of 'conditional statements' in programming?", {"They are used for adding comments to code", "They allow you to make decisions in your code based on certain conditions", "They represent different data types", "They help with code formatting"}, 1))
        '    questions.Add(New Question("What is the purpose of 'comments' in programming code?", {"To execute code", "To prevent code from running", "To provide explanations or notes within the code for documentation and readability", "To create user interfaces"}, 2))
        '    questions.Add(New Question("In programming, what is a 'stack' and a 'queue'?", {"Data types", "Data structures used for storing and accessing elements in a specific order", "Functions for drawing graphics", "Networking protocols"}, 1))
        '    questions.Add(New Question("Who is considered the world's first computer programmer?", {"Charles Babbage", "Alan Turing", "Ada Lovelace", "Grace Hopper"}, 2))
        '    questions.Add(New Question("What machine was Ada Lovelace working on with Charles Babbage when she wrote the first computer program?", {"ENIAC", "UNIVAC", "Analytical Engine", "Difference Engine"}, 2))
        '    questions.Add(New Question("In which year did Ada Lovelace write her notes and programs for the Analytical Engine?", {"1812", "1837", "1843", "1865"}, 2))
        '    questions.Add(New Question("Who designed the first mechanical computer, known as the Analytical Engine?", {"Alan Turing", "John von Neumann", "Charles Babbage", "Ada Lovelace"}, 2))
        '    questions.Add(New Question("When was the first functioning model of the Analytical Engine built?", {"It was never built during Babbage's lifetime", "1940s", "1960s", "2002"}, 0))
        '    questions.Add(New Question("Who was Charles Babbage?", {"A famous painter", "A renowned mathematician and inventor", "A famous actor", "A medieval historian"}, 1))
        '    questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "All of the above"}, 2))
        '    questions.Add(New Question("What is a data structure?", {"A way to structure code in a program", "A way to structure data for storage and efficient access", "A type of programming language", "A data visualization tool"}, 1))
        '    questions.Add(New Question("Which of the following is not a commonly used data structure in programming?", {"Arrays", "Trees", "Algorithms", "Stacks"}, 2))
        '    questions.Add(New Question("Who developed Visual Basic?", {"Microsoft", "IBM", "Apple", "Oracle"}, 0))
        '    questions.Add(New Question("What is Visual Basic?", {"A web browser", "A visual design tool for creating user interfaces", "A programming language and integrated development environment (IDE)", "A type of computer monitor"}, 2))
        '    questions.Add(New Question("Who developed JavaScript?", {"Microsoft", "Sun Microsystems", "Netscape", "IBM"}, 2))
        '    questions.Add(New Question("What is JavaScript?", {"A type of coffee", "A markup language", "A high-level, interpreted programming language for web development", "A document format"}, 2))
        '    questions.Add(New Question("Who originally developed Java?", {"Apple", "IBM", "Microsoft", "Sun Microsystems"}, 3))
        '    questions.Add(New Question("What does 'JRE' stand for in Java?", {"Java Runtime Engine", "Java Runtime Environment", "Java Running Emulator", "Java Resource Editor"}, 1))

        'ElseIf My.Settings.categoryStr = "Random" Then
        '    MsgBox("RAndom")
        'Else
        '    MsgBox("Not It")
        'End If




        'questions.Add(New Question("What does 'IDE' stand for in programming?", {"Integrated Design Environment", "Integrated Development Environment", "Internet Development Engine", "Intelligent Debugging Environment"}, 1))
        'questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "Machine Code"}, 2))
        'questions.Add(New Question("In programming, what is the purpose of a 'variable'?", {"It is used to create loops.", "It represents a value that can change", "It is a type of comment.", "It is used for printing text."}, 1))
        'questions.Add(New Question("Which programming paradigm focuses on defining data structures and the methods that operate on them?", {"Object-Oriented Programming", "Functional Programming", "Procedural Programming", "Imperative Programming"}, 0))
        'questions.Add(New Question("What is the primary function of a 'for loop' in programming?", {"To define classes", "To encapsulate data", "To iterate a specific number of times", "To perform calculations"}, 2))
        'questions.Add(New Question("What does 'API' stand for in programming?", {"Automated Programming Interface", "Application Programming Interface", "Advanced Programming Instruction", "Automated Program Integration"}, 1))
        'questions.Add(New Question("In programming, what is 'debugging'?", {"Adding new features to a program", "The process of identifying and fixing errors in code", "Documenting code", "Optimizing code for speed"}, 1))
        'questions.Add(New Question("Which programming language is often used for web development on the client side?", {"C++", "Python", "JavaScript", "SQL"}, 2))
        'questions.Add(New Question("What does 'OOP' stand for in programming?", {"Object-Oriented Programming", "Object-Oriented Protocol", "Open-Source Project", "Object-Oriented Procedure"}, 0))
        'questions.Add(New Question("What is a 'Boolean' in programming?", {"A data type that represents true or false values", "A type of loop", "A specific error message", "A way to hide code from others"}, 0))
        'questions.Add(New Question("What is the purpose of a 'while loop' in programming?", {"To define classes", "To encapsulate data", "To perform a specific action repeatedly while a condition is true", "To display messages to the user"}, 2))
        'questions.Add(New Question("What is 'algorithm' in programming?", {"A mathematical equation", "A step-by-step procedure for solving a specific problem or performing a task", "A type of programming language", "A programming error message"}, 1))
        'questions.Add(New Question("What is the purpose of 'conditional statements' in programming?", {"They are used for adding comments to code", "They allow you to make decisions in your code based on certain conditions", "They represent different data types", "They help with code formatting"}, 1))
        'questions.Add(New Question("What is the purpose of 'comments' in programming code?", {"To execute code", "To prevent code from running", "To provide explanations or notes within the code for documentation and readability", "To create user interfaces"}, 2))
        'questions.Add(New Question("In programming, what is a 'stack' and a 'queue'?", {"Data types", "Data structures used for storing and accessing elements in a specific order", "Functions for drawing graphics", "Networking protocols"}, 1))
        'questions.Add(New Question("Who is considered the world's first computer programmer?", {"Charles Babbage", "Alan Turing", "Ada Lovelace", "Grace Hopper"}, 2))
        'questions.Add(New Question("What machine was Ada Lovelace working on with Charles Babbage when she wrote the first computer program?", {"ENIAC", "UNIVAC", "Analytical Engine", "Difference Engine"}, 2))
        'questions.Add(New Question("In which year did Ada Lovelace write her notes and programs for the Analytical Engine?", {"1812", "1837", "1843", "1865"}, 2))
        'questions.Add(New Question("Who designed the first mechanical computer, known as the Analytical Engine?", {"Alan Turing", "John von Neumann", "Charles Babbage", "Ada Lovelace"}, 2))
        'questions.Add(New Question("When was the first functioning model of the Analytical Engine built?", {"It was never built during Babbage's lifetime", "1940s", "1960s", "2002"}, 0))
        'questions.Add(New Question("Who was Charles Babbage?", {"A famous painter", "A renowned mathematician and inventor", "A famous actor", "A medieval historian"}, 1))
        'questions.Add(New Question("Which of the following is a high-level programming language?", {"Binary", "Assembly", "C++", "All of the above"}, 2))
        'questions.Add(New Question("What is a data structure?", {"A way to structure code in a program", "A way to structure data for storage and efficient access", "A type of programming language", "A data visualization tool"}, 1))
        'questions.Add(New Question("Which of the following is not a commonly used data structure in programming?", {"Arrays", "Trees", "Algorithms", "Stacks"}, 2))
        'questions.Add(New Question("Who developed Visual Basic?", {"Microsoft", "IBM", "Apple", "Oracle"}, 0))
        'questions.Add(New Question("What is Visual Basic?", {"A web browser", "A visual design tool for creating user interfaces", "A programming language and integrated development environment (IDE)", "A type of computer monitor"}, 2))
        'questions.Add(New Question("Who developed JavaScript?", {"Microsoft", "Sun Microsystems", "Netscape", "IBM"}, 2))
        'questions.Add(New Question("What is JavaScript?", {"A type of coffee", "A markup language", "A high-level, interpreted programming language for web development", "A document format"}, 2))
        'questions.Add(New Question("Who originally developed Java?", {"Apple", "IBM", "Microsoft", "Sun Microsystems"}, 3))
        'questions.Add(New Question("What does 'JRE' stand for in Java?", {"Java Runtime Engine", "Java Runtime Environment", "Java Running Emulator", "Java Resource Editor"}, 1))

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeQuestions()
        ShuffleQuestions()
        InitializeAnswerButtons()
        DisplayQuestion()

        'AddPanelNumbers()
        ListBox1.Enabled = False

    End Sub

    'Dim numLabels(25) As Label
    'Sub AddPanelNumbers()

    '    Dim num As Integer = 100
    '    Dim y As Integer = 10
    '    For i As Integer = 0 To 25

    '        numLabels(i) = New Label With {
    '            .Text = num,
    '            .Location = New Point(10, y),
    '            .BackColor = Color.Transparent,
    '            .TextAlign = HorizontalAlignment.Center
    '        }

    '        If i Mod 5 = 0 Then
    '            numLabels(i).ForeColor = ColorTranslator.FromHtml("#FFC436")
    '        End If

    '        Panel1.Controls.Add(numLabels(i))
    ''        y += 22
    ''        num -= 1

    '    Next
    'End Sub



    Private Sub ShuffleQuestions()
        Dim shuffledQuestions As List(Of Question) = questions.OrderBy(Function() rand.Next()).ToList()
        questions = shuffledQuestions
    End Sub

    Private Sub InitializeAnswerButtons()
        answerButtons = New List(Of Button) From {btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4}
    End Sub

    Private Sub DisplayQuestion()
        For Each button As Button In answerButtons
            button.Enabled = True
        Next

        If currentQuestionIndex < questions.Count Then
            Dim currentQuestion As Question = questions(currentQuestionIndex)
            TextBox1.Text = currentQuestion.Text

            If answerButtons IsNot Nothing Then
                For i As Integer = 0 To currentQuestion.Answers.Length - 1
                    If i < answerButtons.Count Then
                        answerButtons(i).Text = currentQuestion.Answers(i)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub CloseGame()
        Me.Close()
    End Sub

    Private Const CorrectAnswersToWin As Integer = 25
    Private Sub CheckAnswer(selectedIndex As Integer)
        Dim currentQuestion As Question = questions(currentQuestionIndex)

        If currentQuestion.CorrectAnswerIndex = selectedIndex Then

            If currentQuestionIndex < ListBox1.Items.Count Then
                ListBox1.SelectedIndex = ListBox1.Items.Count - currentQuestionIndex - 1
                Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
                MessageBox.Show($"Congratulations! Your grade is now {grade}.")
            End If

            If currentQuestionIndex = 24 Then
                Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
                MessageBox.Show("Congratulations! You answered all the questions you win!")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                GameOver.Show()
                CloseGame()
            End If

            If CheckWinCondition() Then
                Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
                MessageBox.Show($"Congratulations! Your grade is now {grade}.")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                GameOver.Show()
                CloseGame()
            End If
        Else
            If currentQuestionIndex < ListBox1.Items.Count Then
                Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
                MessageBox.Show($"Incorrect! Game Over. Your final grade is {grade}.")
                GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
                GameOver.Show()
                CloseGame()
            End If
        End If
        currentQuestionIndex += 1
        DisplayQuestion()
    End Sub

    Private Function CheckWinCondition() As Boolean
        Dim correctAnswersCount As Integer = 0

        For i As Integer = 0 To currentQuestionIndex
            If questions(i).CorrectAnswerIndex = i Then
                correctAnswersCount += 1
            Else
                correctAnswersCount = 0
            End If

            If correctAnswersCount = CorrectAnswersToWin Then
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub DisableTwoIncorrectAnswers()
        Dim currentQuestion As Question = questions(currentQuestionIndex)
        Dim correctAnswerIndex As Integer = currentQuestion.CorrectAnswerIndex

        Dim incorrectAnswerIndices As New List(Of Integer)

        For i As Integer = 0 To answerButtons.Count - 1
            If i <> correctAnswerIndex Then
                incorrectAnswerIndices.Add(i)
            End If
        Next

        Dim incorrectAnswerIndex1 As Integer = incorrectAnswerIndices(rand.Next(incorrectAnswerIndices.Count))

        incorrectAnswerIndices.Remove(incorrectAnswerIndex1)

        Dim incorrectAnswerIndex2 As Integer = incorrectAnswerIndices(rand.Next(incorrectAnswerIndices.Count))

        answerButtons(incorrectAnswerIndex1).Enabled = False
        answerButtons(incorrectAnswerIndex2).Enabled = False

        MessageBox.Show("You have used the 50/50 lifeline. Two incorrect answers for the current question have been disabled.")
    End Sub

    Private Sub btnAnswer1_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click
        CheckAnswer(0)
    End Sub

    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        CheckAnswer(1)
    End Sub

    Private Sub btnAnswer3_Click(sender As Object, e As EventArgs) Handles btnAnswer3.Click
        CheckAnswer(2)
    End Sub

    Private Sub btnAnswer4_Click(sender As Object, e As EventArgs) Handles btnAnswer4.Click
        CheckAnswer(3)
    End Sub

    Private Sub pb5050_Click(sender As Object, e As EventArgs) Handles pb5050.Click
        DisableTwoIncorrectAnswers()
        pb5050.Enabled = False
        pb5050.Image = My.Resources.x5050
    End Sub

    Private Sub pbIns_Click(sender As Object, e As EventArgs) Handles pbIns.Click
        MessageBox.Show("You have used the Ask the instructor lifeline.")
        pbIns.Enabled = False
        pbIns.Image = My.Resources.xask
    End Sub


    Private Sub pbSkip_Click(sender As Object, e As EventArgs) Handles pbSkip.Click


        'Console.WriteLine(questions(3).Text)


        'If currentQuestionIndex < ListBox1.Items.Count Then
        '    ListBox1.SelectedIndex = ListBox1.Items.Count - currentQuestionIndex - 1
        '    Dim currentGrade As Integer = Convert.ToInt32(ListBox1.SelectedItem)


        '    If ListBox1.SelectedIndex = 0 Then
        '        currentGrade += 1
        '        ListBox1.Items(ListBox1.SelectedIndex) = currentGrade
        '    End If

        MessageBox.Show("You have used the Skip lifeline. The current question will be skipped.")
        'End If

        SkipQuestion()
        pbSkip.Enabled = False
        pbSkip.Image = My.Resources.xswitch




        'If currentQuestionIndex < ListBox1.Items.Count Then
        '    ListBox1.SelectedIndex = ListBox1.Items.Count - currentQuestionIndex - 1
        '    Dim currentGrade As Integer = Convert.ToInt32(ListBox1.SelectedItem)


        '    If ListBox1.SelectedIndex = 0 Then
        '        currentGrade += 1
        '        ListBox1.Items(ListBox1.SelectedIndex) = currentGrade
        '    End If

        '    MessageBox.Show($"You have used the Skip lifeline. The current question will be skipped. Your grade is now {currentGrade}.")
        'End If

        'SkipQuestion()
        'pbSkip.Enabled = False
        'pbSkip.Image = My.Resources.xswitch
    End Sub

    Private Sub SkipQuestion()
        'currentQuestionIndex += 1

        If currentQuestionIndex >= questions.Count Then
            MessageBox.Show("Congratulations! You've completed the game!")
            Dim grade As Integer = Convert.ToInt32(ListBox1.SelectedItem)
            GameOver.Label1.Text = $"Congratulations! Your grade is {grade}."
            GameOver.Show()
            CloseGame()
        Else
            ShuffleQuestions()
            DisplayQuestion()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub
End Class

Public Class Question
    Public Property Text As String
    Public Property Answers As String()
    Public Property CorrectAnswerIndex As Integer

    Public Sub New(questionText As String, answerOptions As String(), correctIndex As Integer)
        Text = questionText
        Answers = answerOptions
        CorrectAnswerIndex = correctIndex
    End Sub
End Class