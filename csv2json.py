'''
Converts a csv file to JSON format.

    usage: python .\csv2json.py <filename> [<column numbers>]
    
    examples: python .\csv2json.py .\lunch_orders.csv #select all columns
              python .\csv2json.py .\lunch_orders.csv 1,3,5 #selects columns 1,3,5 only
'''
import sys, csv

def csv2json(csvFileContents, cols=[]):
    """convert csv file as list of lists into JSON format with only the specified columns included,
    by default, all columns are included."""
    if not cols: #if column numbers were not specified, populate with all columns
        cols = list(range(len(csvFileContents[0])))
    result = ""
    header = csvFileContents[0]
    contents = csvFileContents[1:]
    for row in contents:
        temp="{\n"
        for item in zip([header[x] for x in cols], [row[x] for x in cols]):
            temp += f" \"{item[0]}\":\"{item[1]}\",\n"
        result += temp[:-2] + "\n},\n" #-2 index to remove last comma and newline
    return f"[\n{result[:-2]}\n]"    #-2 index to remove last comma and newline

def json2file(jsonContents, jsonFilename):
    """write json formatted string to file"""
    try:
        with open(jsonFilename, 'w') as outputFile:
            outputFile.write(jsonContents)
    except FileNotFound:
        print(f"could not write to {jsonFilename}")


def main():
    """read csv file where 1st row is the headers and convert to JSON format"""
    try:
        with open(sys.argv[1]) as inputFile:
            reader = csv.reader(inputFile)
            contents = list(reader)
            if len(sys.argv) > 2: #only include specified columns
                jsonFormat = csv2json(contents, [int(x) for x in sys.argv[2].split(',')])
            else: #include all columns
                jsonFormat = csv2json(contents)
            json2file(jsonFormat, sys.argv[1].split(".")[1][1:]+".json")
    except FileNotFound:
        print("invalid filename")
if __name__ == "__main__":
    main()