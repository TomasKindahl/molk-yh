from flask import Flask, render_template
import sqlite3

app = Flask(__name__)

@app.route('/')
def hello_world():
    return 'Hello World'

@app.route('/report/room/<int:room>/lamp/<int:lamp>/state/<state>')
def viewlamp(room, lamp, state):
    # with open("data.log", "a") as filehandle:
    #    filehandle.write(f"room {room} lamp {lamp} state {state}\n")
    conn = sqlite3.connect('lamps.db')
    conn.execute(f"UPDATE lamp SET state = '{state}' WHERE room = {room} AND lamp = {lamp}")
    conn.commit()
    return f"Report: lamp {lamp} in room {room} is set '{state}'"

@app.route('/list')
def list():
   con = sqlite3.connect("lamps.db")
   con.row_factory = sqlite3.Row
   
   cur = con.cursor()
   cur.execute("select * from lamp")
   
   rows = cur.fetchall(); 
   return render_template("list.html",rows = rows)

if __name__ == '__main__':
    app.run()
