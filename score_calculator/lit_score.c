#include <stdio.h>

int main() {
	int questions = 62;
	FILE* out = fopen("README.md", "w");
	if(out == NULL)
		return 1;

	int err = 0, corrects = 0;
	double score = 0;
	fprintf(out, "|%10s|%10s|%10s|\n", "correct", "errors", "score");
	fprintf(out, "|:--------:|:--------:|:--------:|\n");
	for(; err < 62; err++) {
		corrects = questions - err;
		score = corrects * 0.5 - err * 0.25;
		fprintf(out, "|%10d|%10d|%10.2f|\n", corrects, err, score);
	}
	fclose(out);
	return 0;
}
