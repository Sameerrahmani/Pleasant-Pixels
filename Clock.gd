extends Control
onready var date = get_node("date")
onready var time = get_node("time")

func _ready():
	pass
	
func _process(delta):
	var datetime = OS.get_datetime()
	time.text = get_time(datetime)
	date.text = get_date(datetime)
	
func get_time(time):
	var meridiem = "pm"
	var hour = time.hour
	if hour > 12:
		meridiem = "pm"
		hour -= 12
		
	#make sure minutes is always a 2 digit number
	var minute = "%02d" % time.minute
	var time_return = str(hour) +":"+str(minute) + meridiem
	return time_return

func get_date(date):
	var month = date.month
	var day = date.day
	var year = date.year
	date = str(month) +"/"+ str(day) +"/"+str(year)
	return date
