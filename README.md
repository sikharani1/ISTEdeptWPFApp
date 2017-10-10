# ISTEdeptWPFApp
RIT ISTE department website developed as a WPF Application
Project3-WPF

1)API Used – ISTE website

2)Total 7 Methods Invoked 
ABOUT
DEGREES
MINORS
EMPLOYMENT
PEOPLE
RESOURCES
MAP

3)Total 17 different Controls Used
1.	TextBlock
2.	Grid
3.	StackPanel
4.	DataGrid
5.	Canvas
6.	Radio buttons
7.	Web browser
8.	HyperLink
9.	Border
10.	ScrollViewer
11.	TabControl
12.	Button
13.	ToolTip
14.	Image
15.	Frame
16.	Rectangle
17.	WrapPanel



4)To start with a journey of my website
•	Connect to Internet and click on the “Start” button in visual studio to load the WPF application, click on “TabControls” which are at the top of the page to navigate to different views.
•	Select which section you want to visit and it will take you to that tab when you click.
•	The first tab shows the “About” page which is an introduction of our department.
•	There is RIT full name written in the header, there is a map location icon besides the department name ISTE Department if you click it will take you to the RIT location on google map.
•	The ABOUT section shows the introduction to the ISTE department with a dynamic quote regarding our students by the employers in the bottom of the about section.
•	Enjoy the background cover of the about section for a while.
•	Then, there is DEGREES section which contains control buttons when clicked which eventually generates a series of buttons for each degree offered within that stream.
For ex: - when you click “Undergraduate” button, it shows the different degree options offered in Undergraduate and similarly for Graduate and Graduate Advanced certificates. 
•	For user to understand the application better I have given tooltips for each degree button for assistance, which shows what that button will do when clicked. 
•	Click any one of them to see the details in the textblock box down which is dynamically created and contains the respective degree details, which also contains a scrollbar to scroll the content.
•	There is “MINORS” section which shows all the minor degrees with each course details.
•	Click on any of the course listed as radio buttons and the texblock will be populated with the description of that minor degree and the courses details.
•	Then there is “PEOPLE” section which shows the ISTE department professors and their details in the datagrid which is implementing binding to dynamically populate the datagrid with the faculty details in the rows.
•	Click on any of the row to view the image in an image box which is grouped by an enum property “Designation”, and displayed in different color rows accordingly. For ex: - all the Lecturers are shown in similar color rows and all the Professors are shown in different similar color rows and respectively Assistant professor, Senior lecture etc.
•	Then, there is “Employment” section which shows the co-op details. 
•	There is a Co-op table in a data grid which is showing the Co-op details in each company, we can sort it alphabetically and scroll below to see next pages of the table and search.
•	 There is “Map” section showing the Google Map API when hovered which shows where our students work.
•	There is “Resources” section which gives the information about the different resources which are available to the students.
•	Clicking on each canvas control to show the details of each facility resource at the top of the page.
•	At last but not the least there is Web browser section which gives the quick peep into RIT official website portal, which we can view for more updates, to view it click on the “Rit website” button.
•	That’s all hope you enjoyed it.
5)
I have followed MVVM architecture extensively and utilized more than the expected number of wpf controls. I have also consumed almost all methods from the API which is much more than asked. I have also tried to make the interface user friendly and tried to keep it simple and sober as a professional website at the same time impressive. I also thought about the idea to add a map location of our department so that the prospective students can anytime see the location and plan to visit. I tested my website thoroughly for null values if at all returned by the API in some sections. I have tried not to make the website redundant and used different types of interfaces. I also utilized Usercontrol.resources to enhance code reusability. I have also generated controls dynamically in the behind code i.e. the cs file for the views.


Note- To properly run the desktop application in another machine first extract the files and then run the visual studio solution file.








