puts 'Doubler Tripler Programer'
puts 'This program will double or triple your number.'
puts
puts 'Would you like your number to be doubled or tripled?'
puts
response = gets.chomp

def doubleThis num
    numTimes2 = num.to_i * 2
    puts 'Your number ' + num.to_s + ' doubled becomes ' + numTimes2.to_s + '.'
end
    
def tripleThis num
    numTimes3 = num.to_i * 3
    puts 'Your number ' + num.to_s + ' tripled becomes ' + numTimes3.to_s + '.'
end

def ask question
    goodAnswer = false
    while (not goodAnswer)
        puts question
        reply = gets.chomp
if response == 'doubled' or response == 'Doubled'
    puts 'Excellent!'
    puts 'Now please enter a number to be doubled:'
    num = gets.chomp.downcase
    doubleThis num
end
    
if response == 'tripled' or response == 'Tripled'
    puts 'Enter a number to be tripled:'
    num = gets.chomp
    tripleThis num  
  
end




puts 'Have a lovely day!'




