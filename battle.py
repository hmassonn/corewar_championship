#!/usr/bin/python3

from os import path, system, walk, listdir, unlink
import subprocess
from operator import itemgetter
import json

from threading import Thread

OUR_CHAMP = 'double_dash.cor'
champions_pth = './champions/'
POOL_SIZE = 16
TIMEOUT = 0.5

class BrawlerThread(Thread):
	def __init__(self, p1, p2, scores):
		self.p1 = p1
		self.p2 = p2
		self.scores = scores

		Thread.__init__(self)

	def run(self):
		p1 = self.p1
		p2 = self.p2
		scores = self.scores
		try:
			result = subprocess.check_output(['./corewar', './.battle/{}'.format(p1), './.battle/{}'.format(p2)], stderr=open('/dev/null', 'wb'), universal_newlines=True)
		except subprocess.CalledProcessError as err:
			result = err.output
		if "Contestant 1" in result:
			scores[p1] += 1
			print(p1, "killed", p2)
		elif "Contestant 2" in result:
			scores[p2] += 1
			print(p2, "killed", p1)





if not path.exists('.battle'):
	system('mkdir .battle')
else:
	for old in listdir('.battle'):
		unlink(path.join('.battle', old))

to_copy = []
for pth, dirs, files in walk(champions_pth):
	for fname in files:
		if fname.endswith('.s'):
			to_copy.append(path.join(pth, fname))

for fpath in to_copy:
	system('cp "{}" ".battle"'.format(fpath))

for champsrc in listdir('.battle'):
	system('./asm "{}"'.format(path.join('.battle', champsrc)))

cores = [fname for fname in listdir('.battle') if fname.endswith('.cor')]


print("\n\n --- Qualifications ---")

disqualified = []
qualified = []

for p1 in cores:
	try:
		result = subprocess.check_call(
			['./corewar', './.battle/{}'.format(p1)], stderr=open('/dev/null', 'wb'), stdout=open('/dev/null', 'wb'))
	except subprocess.CalledProcessError as err:
		if err.returncode == 43:
			qualified.append(p1)
		else:
			disqualified.append(p1)


print('{} qualifed champions!'.format(len(qualified)))
if len(disqualified):
	print('These dont even compile: {}'.format(' '.join(disqualified)))

print('\n --- BRAWLING ---')

done = set()
tot = len(qualified) ** 2
i = 0
pool = []
scores = {p: 0 for p in qualified}
# for p1 in qualified:
# 	for p2 in qualified:
# 		if p1 == p2 or ':'.join([p1, p2]) in done:
# 			continue
# 		# try:
# 		# 	result = subprocess.check_output(['./corewar', './.battle/{}'.format(p1), './.battle/{}'.format(p2)], stderr=open('/dev/null', 'wb'), universal_newlines=True)
# 		# except subprocess.CalledProcessError as err:
# 		# 	result = err.output
# 		# if "Contestant 1" in result:
# 		# 	scores[p1] += 1
# 		# 	print(p1, "killed it")
# 		# elif "Contestant 2" in result:
# 		# 	scores[p2] += 1
# 		# 	print(p2, "killed it")
# 		# done.add(':'.join([p1, p2]))
# 		# done.add(':'.join([p2, p1]))

# 		if len(pool) < POOL_SIZE:
# 			pool.append(BrawlerThread(p1, p2, scores))
# 		elif len(pool) == POOL_SIZE:
# 			for bt in pool:
# 				bt.start()
# 			for bt in pool:
# 				bt.join(TIMEOUT)
# 				if bt.isAlive():
# 					print(bt.p1, 'vs', bt.p2, 'timeout')
# 			pool = [BrawlerThread(p1, p2, scores)]
# 			print(int(i*100/tot), 'percent done')

# 		i += 1

for p1 in qualified:
	if p1 != OUR_CHAMP:
		# print(p1, OUR_CHAMP)
		pool.append(BrawlerThread(p1, OUR_CHAMP, scores))

for ct in pool:
	ct.start()

for ct in pool:
	ct.join()

for key, val in reversed(sorted(scores.items(), key=itemgetter(1))):
	print(key, val)

with open('results.json', 'w') as f:
	f.write(json.dumps(scores, indent=4))

print()
print(OUR_CHAMP, "beat {} out of {} champions".format(scores[OUR_CHAMP], len(qualified) - 1))
